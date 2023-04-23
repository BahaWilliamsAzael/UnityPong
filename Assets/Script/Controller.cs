using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] float playerMovement;
    [SerializeField] Rigidbody2D rbPlayer;

    Vector3 restartPosition;

    void Start()
    {
        restartPosition = transform.position;
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (gameObject.tag == "Player 1")
        {
            if (Input.GetKey(KeyCode.W))
                rbPlayer.velocity = Vector2.up * playerMovement;

            else if (Input.GetKey(KeyCode.S))
                rbPlayer.velocity = Vector2.down * playerMovement;

            else
                rbPlayer.velocity = Vector2.zero;
        }

        if (gameObject.tag == "Player 2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
                rbPlayer.velocity = Vector2.up * playerMovement;

            else if (Input.GetKey(KeyCode.DownArrow))
                rbPlayer.velocity = Vector2.down * playerMovement;

            else
                rbPlayer.velocity = Vector2.zero;
        }
    }

    public void Reset()
    {
        transform.position = restartPosition;
        rbPlayer.velocity = Vector2.zero;
    }
}
