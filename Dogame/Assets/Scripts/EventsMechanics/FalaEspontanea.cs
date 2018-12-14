using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalaEspontanea : MonoBehaviour {

    public GameObject fala;
    public float timeToChange;
    public AudioClip dialogSound;
    public AudioSource audioSource;

    private void Start()
    {
        fala.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            StartCoroutine(AparecerSumir(timeToChange));
    }

    public IEnumerator AparecerSumir(float time)
    {
        audioSource.PlayOneShot(dialogSound, 0.5f);
        fala.SetActive(true);
        yield return new WaitForSeconds(timeToChange);
        fala.SetActive(false);

    }

}
