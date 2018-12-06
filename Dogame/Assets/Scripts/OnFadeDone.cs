using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnFadeDone : MonoBehaviour {

    public string LevelToLoad;

    public void ChangeScene()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
