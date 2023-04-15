using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    private Score scoreScript;



    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        scoreScript = GameObject.Find("score").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 3;
            InvokeRepeating("ScorePlus", 0, 1);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed /= 3;
            CancelInvoke();
        }
    }

    void ScorePlus()
    {
        scoreScript.score++;
    }
}
