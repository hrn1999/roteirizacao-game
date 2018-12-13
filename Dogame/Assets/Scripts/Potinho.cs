using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potinho : MonoBehaviour {

    public bool potinhoCheio;
    public bool chamar;
    public bool aguaCheia = false;

    public Material mat;

    public Sprite[] potinho;
    public SpriteRenderer objswitch;
    public GameObject aguaPrefab;



    private void Start()
    {
        objswitch = gameObject.GetComponent<SpriteRenderer>();
        aguaPrefab.SetActive(false);
        chamar = false;
    }

    private IEnumerator OnTriggerStay2D(Collider2D collision)
    {
        chamar = true;
        if (chamar == true && aguaCheia == true)
        {

            Debug.Log("Entrou!");
            aguaPrefab.SetActive(true);
            yield return new WaitForSeconds(0.51f);
            objswitch.sprite = potinho[1];
            yield return new WaitForSeconds(0.51f);
            aguaPrefab.SetActive(false);
            potinhoCheio = true;
        }

        if(potinhoCheio == true && Input.GetKeyDown("z"))
        {
            mat.SetFloat("_VRadius", 1.0f);
            objswitch.sprite = potinho[0];
            potinhoCheio = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        chamar = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        chamar = false;
    }

}
