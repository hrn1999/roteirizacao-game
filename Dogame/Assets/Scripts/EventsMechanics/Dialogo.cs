using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{

    public GameObject[] diag;
    public AudioSource audio;
    public AudioClip clip;

    private int i = 0;

    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (i < diag.Length)
            {
                diag[i].SetActive(true);
                
            }

            if (Input.GetKeyDown("z") && i < diag.Length)
            {
                diag[i].SetActive(false);
                Debug.Log(i);
                audio.PlayOneShot(clip, 0.7f);
                if (i + 1 <= diag.Length)
                {
                    i++;
                }
            }
            else if ((i + 1) > diag.Length && i != diag.Length)
            {
                diag[i].SetActive(false);
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            diag[i].SetActive(false);
        }
    }
}
