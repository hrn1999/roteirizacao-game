using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour {

    public TextMeshProUGUI textDisplay;
    public GameObject[] dialogBox;
    public string[] sentences;
    public float typingSpeed;
    private int index;

    public Animator dialogBoxAnim;
    public GameObject continueButton;
    private AudioSource source;

    void Start()
    {
        StartCoroutine(Type());
    }
  
    IEnumerator Type() {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    void Update() {
            if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }
    public void NextSentence() {
        source.Play();
        dialogBoxAnim.SetTrigger("Change");
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else {
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }
    

}
