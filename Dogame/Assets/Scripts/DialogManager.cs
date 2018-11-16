using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour {

    public GameObject dBox;
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public Collider2D dog;
    private int index;

    public bool dActive;

    public float typingSpeed;

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
