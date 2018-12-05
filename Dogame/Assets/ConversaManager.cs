using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConversaManager : MonoBehaviour {
    public GameObject[] dbox;
    public GameObject dtextObj;
    public TextMeshProUGUI dtext;

    public string[] dialoaglines;
    public int currentLines;

    public bool dialogActive;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(dialogActive && Input.GetKeyDown(KeyCode.Space))
        {
            currentLines++;
        }
        if(currentLines >= dialoaglines.Length)
        {
            dtextObj.SetActive(false);
            dbox[currentLines].SetActive(false);
            dialogActive = false;
            currentLines = 0;
        }

        dtext.text = dialoaglines[currentLines];
	}

    //uma fala
    public void ShowBox(string dialogue)
    {
        dialogActive = true;
        dbox[currentLines].SetActive(true);
        dtextObj.SetActive(true);
        dtext.text = dialogue;
    }
   
    //mais q uma fala
    public void ShowDialogue()
    {
        dialogActive = true;
        dbox[currentLines].SetActive(true);
        dtextObj.SetActive(true);
    }
}
