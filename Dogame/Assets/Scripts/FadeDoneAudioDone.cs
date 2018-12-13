using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeDoneAudioDone : MonoBehaviour
{

    public GameObject hand;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hand = GameObject.Find("Music");
            Destroy(hand);
        }
    }

}
