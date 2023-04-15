using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Score : MonoBehaviour
{
    public float score;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ScorePlus", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            score += 5;
        }
    }

    void ScorePlus()
    {
        score++;
    }
}
