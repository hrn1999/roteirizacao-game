using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasFrase : MonoBehaviour {

    public GameObject text;
    public GameObject text2;

    public float timeBetween;


    private void Start()
    {
        text.SetActive(false);
        text2.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TransitionOn(timeBetween));
        }
    }

    IEnumerator TransitionOn(float time)
    {
        yield return new WaitForSeconds(10);
        text.SetActive(true);
        yield return new WaitForSeconds(time);
        text.SetActive(false);
        text2.SetActive(true);
    }
}
