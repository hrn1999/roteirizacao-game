﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineZoomIn : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public float zoomIn;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (vcam.m_Lens.OrthographicSize > zoomIn)
            {
                vcam.m_Lens.OrthographicSize -= Time.deltaTime;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (vcam.m_Lens.OrthographicSize > zoomIn)
            {
                vcam.m_Lens.OrthographicSize -= Time.deltaTime;
            }
        }
    }
}
