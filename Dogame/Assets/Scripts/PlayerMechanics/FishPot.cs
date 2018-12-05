using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPot : MonoBehaviour {

    public Sprite[] waterContainer;
    public SpriteRenderer objToChange;
    public GameObject waterAnim;

    public float timeToWait;

    void Start () {
        waterAnim.SetActive(false);
        objToChange = gameObject.GetComponent<SpriteRenderer>();
	}

    private IEnumerator OnTriggerStay2D(Collider2D collision)
    {

        if(Input.GetKeyDown("x") && collision.CompareTag("Player"))
        {
            waterAnim.SetActive(true);
            yield return new WaitForSeconds(timeToWait);
            objToChange.sprite = waterContainer[1];
            yield return new WaitForSeconds(timeToWait);
            waterAnim.SetActive(false);
            yield return new WaitForSeconds(timeToWait);
            Destroy(waterAnim);
        }
    }
}
