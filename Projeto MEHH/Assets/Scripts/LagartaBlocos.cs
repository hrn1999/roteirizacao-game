using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagartaBlocos : MonoBehaviour {

    private bool chamar;

    public List<GameObject> plataformas = new List<GameObject>();

    private void Start()
    {
        chamar = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        chamar = true;
        Debug.Log("ENTREI");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        chamar = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (chamar == true && Input.GetKeyDown("x"))
        { 
            for (int i = 0; i < plataformas.Count; i++)
            {
                plataformas[i].SetActive(true);
            }
        }
    }
}
