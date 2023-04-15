using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRigidB;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followPlayer = (player.transform.position - transform.position).normalized;

        enemyRigidB.AddForce(followPlayer * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
