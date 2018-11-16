using UnityEngine;
using Cinemachine;

public class ZoomOut : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public float zoomOut;

    //ampliar do normal
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (vcam.m_Lens.OrthographicSize <= zoomOut)
            {
                vcam.m_Lens.OrthographicSize += Time.deltaTime;
            }
        }
    }
}
