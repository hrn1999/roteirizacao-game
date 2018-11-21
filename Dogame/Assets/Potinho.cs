using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potinho : MonoBehaviour {

    public Sprite[] potinho;
    public SpriteRenderer objswitch;
    public GameObject water;

    private void Start()
    {
        water.SetActive(false);
        objswitch = gameObject.GetComponent<SpriteRenderer>();
    }
    private IEnumerator OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown("x") && collision.CompareTag("Player")) {
            water.SetActive(true);
            yield return new WaitForSeconds(0.51f);
            objswitch.sprite = potinho[1];
            yield return new WaitForSeconds(0.51f);
            water.SetActive(false);
        }


    }

}
