using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbBall;
    [SerializeField] float ballMovement;

    Vector3 restartPosition;
    void Start()
    {
        BounceBall();
        restartPosition = transform.position;
    }

    void BounceBall()
    {
        float ballDX = Random.Range(-1f, 2f) > 0 ? -1f : 1f;
        float ballDY = Random.Range(-1f, 2f) > 0 ? -1f : 1f;
        rbBall.velocity = new Vector2(ballDX * ballMovement, ballDY * ballMovement);
    }

    public void Reset()
    {
        rbBall.velocity = Vector2.zero;
        BounceBall();
        transform.position = restartPosition;
    }
}
