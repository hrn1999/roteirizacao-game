using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionDownKick : MonoBehaviour
{

    [Header("Material Values")]
    public Material mat;
    public float visionRadius;

    public float howMuch;
    public float timeToChange;
    
    [Header("Bad Strings")]
    public GameObject bstring;
    public AudioSource audioSource;
    public AudioClip chute;
    public Rigidbody2D tokick;
    public float kickforce;

    private void Awake()
    {
        bstring.SetActive(false);
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
        audioSource.PlayOneShot(chute, 0.3f);
        bstring.SetActive(true);
        visionRadius = mat.GetFloat("_VRadius");
        mat.SetFloat("_VRadius", visionRadius - howMuch);

        tokick.AddForce(transform.up * kickforce);
        tokick.AddForce(transform.right * kickforce);

        yield return new WaitForSeconds(time);

        bstring.SetActive(false);
        Destroy(gameObject);
    }
}
