using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeixeAgua : MonoBehaviour {

    private bool beber;

    public GameObject bebedouro;

    private void Start()
    {
        beber = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        beber = true;
        Debug.Log("ENTREI");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        beber = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (beber == true && Input.GetKeyDown("x"))
        {
            bebedouro.
        }
    }
}
