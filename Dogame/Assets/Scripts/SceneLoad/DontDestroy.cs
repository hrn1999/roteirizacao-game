using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {

    public GameObject backgroundSound;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
