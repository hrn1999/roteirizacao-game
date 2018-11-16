using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicListener : MonoBehaviour {
    private KeyCode[] sequence = new KeyCode[]{
        KeyCode.R,
        KeyCode.T,
        KeyCode.R
    };
    private int sequenceIndex;

    private void Update()
    {
        if (Input.GetKeyDown(sequence[sequenceIndex]))
        {
            if (++sequenceIndex == sequence.Length)
            {
                sequenceIndex = 0;
                print("TÁ LÁ");
            }
        }
        else if (Input.anyKeyDown) sequenceIndex = 0;
    }

}

