using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> spherePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        float randomDelay = Random.Range(2, 6);
        InvokeRepeating("SpawnRandom", 1, randomDelay);
    }

    // Update is called once per frame
    void Update()
    {      

    }

    void SpawnRandom()
    {
        int sphereIndex = Random.Range(0, spherePrefabs.Count);

        float zRange = Random.Range(-12, 12);
        Vector3 spawnPos = new Vector3(0, 15, zRange);

        Instantiate(spherePrefabs[sphereIndex], spawnPos, spherePrefabs[sphereIndex].transform.rotation);
    }
}
