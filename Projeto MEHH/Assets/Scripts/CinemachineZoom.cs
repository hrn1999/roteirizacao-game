using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CinemachineZoom : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public float m_zinicial;
    public float m_zoomax;
    public float m_zoomin;

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (vcam.m_Lens.OrthographicSize <= m_zoomax)
            vcam.m_Lens.OrthographicSize += Time.deltaTime;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(vcam.m_Lens.OrthographicSize >= m_zinicial)
        {
            vcam.m_Lens.OrthographicSize -= Time.deltaTime;
        }
    }


}
