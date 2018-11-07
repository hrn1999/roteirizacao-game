using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineZoomOut : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public float zoomOut;
    
    //ampliar do normal
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //ampliar do normal
            if (vcam.m_Lens.OrthographicSize <= zoomOut)
            {
                vcam.m_Lens.OrthographicSize += Time.deltaTime;
            }
        }  
    }
}
