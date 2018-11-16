using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encher : MonoBehaviour {

    public Sprite[] vazio_cheio;
    public SpriteRenderer potinho;

    private void Start()
    {
        potinho = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.X) && collision.CompareTag("Player"))
        {
            potinho.sprite = vazio_cheio[1];
        }
    }
}
