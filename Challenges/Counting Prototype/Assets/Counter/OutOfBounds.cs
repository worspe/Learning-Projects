using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }

        Range();    
    }

    void Range()
    {
        Vector3 range = new Vector3(transform.position.x, transform.position.y, 12);
        if (transform.position.z > 12)
        {
            transform.position = range;
        }else if (transform.position.z < -12)
        {
            transform.position = -range;
        }
    }
}
