using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public GameObject[] dialogBox;
    public GameObject haveDialog;
    public int controller;

    [TextArea(10, 15)]
    public string[] sentences;

    public float typingSpeed;
    private int index;

    public Animator dialogBoxAnim;
    public GameObject continueText;
    private AudioSource source;
    
  
    IEnumerator Type() {
        dialogBox[controller].SetActive(true);
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            haveDialog.SetActive(true);
            if (Input.GetKeyDown("space"))
            {
                beginDialog();
            }
        }
    }

    void Update() {
            if(textDisplay.text == sentences[index])
            {
                continueText.SetActive(true);
                if (Input.GetKeyDown("space"))
                {
                    beginDialog();
                }
            }
    }

    public void beginDialog() {
        source.Play();
        dialogBoxAnim.SetTrigger("Change");
        continueText.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else {
            textDisplay.text = "";
            continueText.SetActive(false);
        }
    }
    

}
