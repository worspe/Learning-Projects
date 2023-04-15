using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;

    private float startDelay = 2;
    private float repeatTime = 2;
    private Vector3 spawnPos = new Vector3(26, 0, 0);
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacles", startDelay, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        int spawnIndex = Random.Range(0, obstaclePrefab.Length);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab[spawnIndex], spawnPos, obstaclePrefab[spawnIndex].transform.rotation);
        }
    }
}
