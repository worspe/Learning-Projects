using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 0.0f;
    private bool dogReady = true;

    // Update is called once per frame
    void Update()
    {      
        // On spacebar press, send dog
        cooldown += Time.deltaTime;
        if (cooldown > 1.5f)
        {
            dogReady = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && dogReady == true)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 0;
            dogReady = false;
        }
        
    }
}
