using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody powerRb;
    private GameObject enemy;
    public GameObject enemy2;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        powerRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.Find("Enemy");
        Vector3 followEnemy = (enemy.transform.position + transform.position).normalized;

        powerRb.AddForce(followEnemy * speed);
    }
}
