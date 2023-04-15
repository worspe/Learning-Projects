using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject players;
    public GameObject yourGameObject;
    private Vector3 offset2 = new Vector3(0, 2, 1);
    public float cameraInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        yourGameObject = GameObject.Find("Camera2");
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = players.transform.position + offset2;
        transform.localRotation = players.transform.localRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            gameObject.SetActive(true);
        }
    }
}
