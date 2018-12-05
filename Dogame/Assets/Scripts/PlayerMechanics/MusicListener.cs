using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicListener : MonoBehaviour {
    private KeyCode[] sequence = new KeyCode[]{ // Sequência de botões da lagarta
        KeyCode.R,
        KeyCode.T,
        KeyCode.R
    };

    private KeyCode[] sequence2 = new KeyCode[]{ // Sequência de botões para acerto
        KeyCode.Y,
        KeyCode.U,
        KeyCode.I
    };

    public Animator animator;

    private bool fluteOpen = false;

    private int sequenceIndex;
    private int sequenceIndex2;

    public GameObject flute;
    public GameObject lagarta;
    public Button[] botoes = new Button[5];
    public float delay = 1.0f;

    private void Update(){
        if (Input.GetKeyDown("m"))
        {
            if (fluteOpen == false)
            {
                animator.SetBool("IsPlaying", true);
                fluteOpen = true;
                flute.SetActive(true);
            }
            else if (fluteOpen == true)
            {
                animator.SetBool("IsPlaying", false);
                fluteOpen = false;
                flute.SetActive(false);
            }
        }

        // SEQUÊNCIA 1
        if (Input.GetKeyDown(sequence[sequenceIndex]) && fluteOpen == true)
        { // Quando alguém digita um botão da sequência
            if (++sequenceIndex == sequence.Length)
            {    // E esse botão é o último da sequência
                sequenceIndex = 0;                      // É contado o acerto
                print("entrou 1");
                lagarta.GetComponent<LagartaBlocos>().musicPlayed = true;
            }
        }
        else if (Input.anyKeyDown) sequenceIndex = 0; // Caso contrário, ele volta tudo do zero


        // SEQUÊNCIA 2
        if (Input.GetKeyDown(sequence2[sequenceIndex2]) && fluteOpen == true)
        { // Quando alguém digita um botão da sequência
            if (++sequenceIndex2 == sequence2.Length)
            {    // E esse botão é o último da sequência
                sequenceIndex2 = 0;                      // É contado o acerto
                print("entrou 2");
            }
        }
        else if (Input.anyKeyDown) sequenceIndex2 = 0; // Caso contrário, ele volta tudo do zero
    }

    public void disableButton(){
        StartCoroutine(Disable());        
    }

    public void disableOtherButtons(Button[] outrosBotoes, bool enabled)
    {
        StartCoroutine(disableFluteButtons(outrosBotoes, enabled));
    }

    IEnumerator Disable(){ // Usado IEnumerator por causa do WaitForSeconds
        for (int i = 0; i < botoes.Length; i++) { botoes[i].gameObject.SetActive(false); }
        yield return new WaitForSeconds(delay);
        for (int i = 0; i < botoes.Length; i++) { botoes[i].gameObject.SetActive(true); }
    }



    IEnumerator disableFluteButtons(Button[] outrosBotoes, bool enabled)
    {
        for (int i = 0; i < outrosBotoes.Length; i++) { outrosBotoes[i].gameObject.SetActive(enabled); }
        yield return new WaitForSeconds(0);
    }
}

