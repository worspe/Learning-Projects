using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVehicles : MonoBehaviour
{
    public float speedCar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedCar);
    }
}
