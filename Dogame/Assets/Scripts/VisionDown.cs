using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDown : MonoBehaviour
{

    [Header("Material Values")]
    public Material mat;
    public float visionRadius;

    public float howMuch;
    public float timeToChange;

    public bool destroy;
    //[Header("Bad Strings")]
    //public GameObject bstring;
    //public AudioSource chute;

    private void Awake()
    {
        //bstring.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TakeHit(timeToChange));
        }
    }

    private IEnumerator TakeHit(float time)
    {
        //chute.Play();
        //bstring.SetActive(true);
        visionRadius = mat.GetFloat("_VRadius");
        mat.SetFloat("_VRadius", visionRadius - howMuch);
        yield return new WaitForSeconds(time);
        //bstring.SetActive(false);
        if (destroy == true)
            Destroy(this.gameObject);
    }
}
