using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    [SerializeField]
    private string levelToChange;

    public void StartGame()
    {
        SceneManager.LoadScene(levelToChange);
    }

    public void ExitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }


}
