using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager1 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 24;
    private float spawnPosY = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal2", 2, 5);
        InvokeRepeating("SpawnRandomAnimalR", 2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal2()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(-spawnRangeX, spawnPosY, Random.Range(8, 13));

        Instantiate(animalPrefabs[animalIndex], spawnPosition, Quaternion.LookRotation(Vector3.right));
    }

    void SpawnRandomAnimalR ()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, spawnPosY, Random.Range(8, 13));

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
    }
}
