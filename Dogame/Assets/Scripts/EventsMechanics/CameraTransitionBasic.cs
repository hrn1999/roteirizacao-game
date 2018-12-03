using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraTransitionBasic : MonoBehaviour
{
    [Header("Cinemachine Components")]
    public CinemachineBlendDefinition customBlend;
    public CinemachineVirtualCamera mainCamera;
    public CinemachineVirtualCamera transitionCamera;
    public CinemachineBrain myBrain;

    [Header("Configuration Components")]
    public float timeToChange;

    private void Awake()
    {
        myBrain.m_DefaultBlend = customBlend;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(TransitionOn(timeToChange));
        }
    }

    IEnumerator TransitionOn(float time)
    {
        mainCamera.gameObject.SetActive(false);
        transitionCamera.gameObject.SetActive(true);
        yield return new WaitForSeconds(time);
        transitionCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
}