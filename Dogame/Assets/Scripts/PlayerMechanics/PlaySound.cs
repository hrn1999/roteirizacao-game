using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour {
    public AudioSource audio;
    public GameObject MusicListener;
    public float velocidade;
    public string tecla;
    public Button[] outrosBotoes;
    const float originalAudio= 1;

	void Update () {
		if(Input.GetKeyDown(tecla)){
            if (!audio.isPlaying){
                audio.enabled = true;
                audio.loop = true;
                audio.Play();
                MusicListener.GetComponent<MusicListener>().disableOtherButtons(outrosBotoes, false);
                StartCoroutine(FadeIn());
            }
        }

        if (Input.GetKeyUp(tecla)){
            MusicListener.GetComponent<MusicListener>().disableOtherButtons(outrosBotoes, true);
            StartCoroutine(FadeOut());
        }
	}

    

    IEnumerator FadeIn(){
        float fadeAudio = 0;

        while (audio.volume < originalAudio){
            fadeAudio += velocidade;
            audio.volume = fadeAudio;
            yield return new WaitForSeconds(0.001f);
        }

        audio.enabled = true;
        audio.loop = true;
    }

    IEnumerator FadeOut(){
        float fadeAudio = 1;

        while (audio.volume != 0){
            fadeAudio -= velocidade;
            audio.volume = fadeAudio;
            yield return new WaitForSeconds(0.001f);
        }

        audio.enabled = false;
        audio.loop = false;
        MusicListener.GetComponent<MusicListener>().disableButton();
    }
}

    