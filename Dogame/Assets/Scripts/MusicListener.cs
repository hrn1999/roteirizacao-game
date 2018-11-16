using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicListener : MonoBehaviour {
    private KeyCode[] sequence = new KeyCode[]{ // Sequência de botões para acerto
        KeyCode.R,
        KeyCode.T,
        KeyCode.R
    };
    private int sequenceIndex;

    public Button[] botoes = new Button[5];
    public float delay = 1.0f;

    private void Update(){
        if (Input.GetKeyDown(sequence[sequenceIndex])){ // Quando alguém digita um botão da sequência
            if (++sequenceIndex == sequence.Length){    // E esse botão é o último da sequência
                sequenceIndex = 0;                      // É contado o acerto
            }
        }

        else if (Input.anyKeyDown) sequenceIndex = 0; // Caso contrário, ele volta tudo do zero
    }

    public void disableButton(){
        StartCoroutine(Disable());        
    }

    IEnumerator Disable(){ // Usado IEnumerator por causa do WaitForSeconds
        for (int i = 0; i < botoes.Length; i++) { botoes[i].gameObject.SetActive(false); }
        yield return new WaitForSeconds(delay);
        for (int i = 0; i < botoes.Length; i++) { botoes[i].gameObject.SetActive(true); }
    }
}

