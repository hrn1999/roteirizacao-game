using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class CameraTransitionScene : MonoBehaviour {
    //A diferença deste Script para o CameraTransitionBasic
    //e o SceneByCollision é a possibilidade de realizar uma animação de Camera
    //antes de acontecer a troca de Cena.

    //Lembrando que com este Script a camera só realiza a Transiçaõ de ida.
    [Header("Cinemachine Components")]
    public CinemachineBlendDefinition customBlend;
    public CinemachineVirtualCamera mainCamera;
    public CinemachineVirtualCamera transitionCamera;
    public CinemachineBrain myBrain;

    [Header("Configuration Components")]
    public float timeToChange;
    public string levelToChange;
    public Animator animator;

    private void Awake()
    {
        myBrain.m_DefaultBlend = customBlend;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(LoadLevelAfterCollision(timeToChange));
        }
    }

    IEnumerator LoadLevelAfterCollision(float time)
    {
        mainCamera.gameObject.SetActive(false);
        transitionCamera.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        animator.SetTrigger("FadeOut");
    }

    public void OnFadeDone()
    {
        SceneManager.LoadScene(levelToChange);
    }
}
