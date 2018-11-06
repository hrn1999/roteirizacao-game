using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineZoom : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public void Zoom(float zoomValor) { 
        if(vcam.m_Lens.OrthographicSize <= zoomValor){
            vcam.m_Lens.OrthographicSize += Time.deltaTime * 0.2f;
            
        }
    }
}
