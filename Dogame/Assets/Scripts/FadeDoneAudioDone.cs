using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeDoneAudioDone : MonoBehaviour {

    public string LevelToLoad;
    public GameObject hand;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hand = GameObject.Find("Music");
            audioSource = hand.GetComponent<AudioSource>();
            StartCoroutine(FadeOut(LevelToLoad));
        }
    }


    public IEnumerator FadeOut(string level)
    {
        float fadeAudio = 1;
        float velocidade = 0.1f;

        while (audioSource.volume != 0)
        {
            fadeAudio -= velocidade;
            audioSource.volume = fadeAudio;
            yield return new WaitForSeconds(0.001f);
        }

        audioSource.enabled = false;
        audioSource.loop = false;
        hand.GetComponent<MusicListener>().disableButton();

        yield return new WaitForSeconds(2);

        Destroy(hand);
    }
}
