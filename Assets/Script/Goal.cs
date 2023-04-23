using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (-transform.position.x > 0)
                FindObjectOfType<GameManager>().P2Scores();

            else
                FindObjectOfType<GameManager>().P1Scores();

        }
    }
}
