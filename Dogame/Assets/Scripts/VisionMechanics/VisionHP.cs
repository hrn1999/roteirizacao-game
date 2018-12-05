using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionHP : MonoBehaviour {

    [Header("Material Values")]
    public Material mat;
    [Range(0, 1)][SerializeField]
    private float visionRadius;
    [Range(0, 1)][SerializeField]
    private float visionSoftness;

    [Header("Canvas Configuration")]
    public float CharacterVision;

    private void Awake()
    {
        mat.SetFloat("_VRadius", visionRadius);
        mat.SetFloat("_VSoft", visionSoftness);
    }

    private void Update()
    {
        mat.SetFloat("_VRadius", visionRadius);
    }

}
