using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour {

    public GameObject lista[];

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            for(int i = 0; i < lista ; i++)
            {
                
            }
        }
    }
}
