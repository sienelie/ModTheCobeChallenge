using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 cubePos = new Vector3(3, 4, 1);
    public Vector3 cubeScale = Vector3.one * 1.3f;
    public Color cubeColor = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    public float cubeRotation = 10.0f;
    public float rotationSpeed = 10.0f;

    void Start()
    {
        transform.position = cubePos;
        transform.localScale = cubeScale;
        
        Material material = Renderer.material;

        material.color = cubeColor;
    }
    
    void Update()
    {
        transform.Rotate(cubeRotation * Time.deltaTime, rotationSpeed, 100.0f);
    }
}
