using UnityEngine;
using Cinemachine;

public class ZoomOut : MonoBehaviour {

    public CinemachineVirtualCamera vcam;

    public float zoom;

    //ampliar do normal
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (vcam.m_Lens.FieldOfView <= zoom)
            {
                vcam.m_Lens.FieldOfView += Time.deltaTime;
                /*
                Material mat;
                mat.SetFloat("_Vignaaa", 1);
                */
            }
            else if (vcam.m_Lens.FieldOfView > zoom)
            {
                vcam.m_Lens.FieldOfView -= Time.deltaTime;
            }
        }
    }
}
