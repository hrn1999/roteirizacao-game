using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{

    public GameObject[] diag;
    public AudioSource audio;
    public AudioClip clip;

    private int i = 0;

    private bool firstTime = true;
    private bool aux = true;
    private bool dentro = false;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            if (firstTime)
            {
                audio.PlayOneShot(clip, 0.7f);
                diag[i].SetActive(true);
                firstTime = false;
                print("entrou");
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dentro = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            diag[i].SetActive(false);
            dentro = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && i <= diag.Length && dentro == true)
        {
            if (i < diag.Length)
            {
                diag[i].SetActive(false);

                i++;
                if (i < diag.Length)
                {
                    audio.PlayOneShot(clip, 0.7f);
                    diag[i].SetActive(true);
                    print(i);
                }
            }
        }
    }
}
