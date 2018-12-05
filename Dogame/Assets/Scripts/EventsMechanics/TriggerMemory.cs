using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMemory : MonoBehaviour {

    public GameObject objectToSee;
    public SpriteRenderer changeAlpha;
    public float timeToChange;

    private void Start()
    {
        objectToSee.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            objectToSee.SetActive(true);
            StartCoroutine(VisionTime(timeToChange));
        }


    }

    public IEnumerator VisionTime(float time)
    {
        yield return new WaitForSeconds(time);
        objectToSee.SetActive(false);
        Destroy(gameObject);
    }
}
