using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 1, 1);
        transform.localScale = Vector3.one * 2f;
        
        Material material = Renderer.material;

        
    }
    
    void Update()
    {
        Material material = Renderer.material;

        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        material.color = new Color(0.5f, Random.Range(0, 2f), Random.Range(0, 2f), 0.4f);
    }
}
