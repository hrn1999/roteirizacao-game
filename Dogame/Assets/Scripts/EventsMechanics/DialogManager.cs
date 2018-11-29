using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour {
    [Header("Configuração Canvas")]
    public TextMeshProUGUI textDisplay; // Onde sera escrito a frase;
    public GameObject haveDialog; // Aviso de Dialogo;
    public GameObject textObj;

    [Header("Sequência do dialogo")]
    public GameObject[] dialogBox; // Quem vai falar a frase;
    [TextArea(10, 15)]
    public string[] sentences; // Onde será colocado cada frase;

    [Header("Animações e Sons")]
    public Animator dialogBoxAnim;
    public GameObject continueText;
    private AudioSource source;

    public int controller;
    public bool isDialog;
    public float tempo;

    private void Start()
    {
        Debug.Log("Number of sentenses " + sentences.Length);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            haveDialog.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown("space") && collision.CompareTag("Player")) {
            Dialog();
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            haveDialog.SetActive(false);
        }
    }

    public void Dialog()
    {
            dialogBox[controller].SetActive(true);
            textObj.SetActive(true);
            textDisplay.text = sentences[controller];
            continueText.SetActive(true);
            if (Input.GetKeyDown("z"))
            {
                dialogBox[controller].SetActive(false);
                textObj.SetActive(false);
                textDisplay.text = sentences[controller];
                continueText.SetActive(false);
                if(controller <= sentences.Length)
                {
                    controller++;
                    Dialog();
                }
            }
        }
}
