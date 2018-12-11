using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversaHolder : MonoBehaviour
{

    public string dialogue;
    private ConversaManager cMan;

    public string[] dialogueLines;
    // Use this for initialization
    void Start()
    {
        cMan = FindObjectOfType<ConversaManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DogPlayer")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                if (!cMan.dialogActive)
                {

                    cMan.dialoaglines = dialogueLines;
                    cMan.currentLines = 0;
                    cMan.ShowDialogue();
                }
            }
        }
    }
}