using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour {

    public GameObject[] diag;

    private int i = 0;

    private void Start()
    {
        print(diag.Length);
    }
    // Update is called once per frame
    void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            dialogo();
    }

    void dialogo()
    {
        
        
            diag[i].SetActive(true);
            if (Input.GetKeyDown("z") && i < diag.Length)
            {
                diag[i].SetActive(false);
                i++;
            }
            else if (i >= diag.Length)
            {
                diag[i].SetActive(false);
            }
        
    }

    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Input.GetKeyDown("z") && i < diag.Length)
            {
                diag[i].SetActive(false);
                i++;
            }
            else if(i >= diag.Length)
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
    }*/
}
