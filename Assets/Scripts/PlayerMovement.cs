using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed, jumpSpeed;
    public Rigidbody2D playerRB;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3;
        jumpSpeed = moveSpeed * 3;
    }

    // Update is called once per frame
    void Update()
    {
        // velocity controls the speed of the rigidbody
        // Input is Unity's input system
        playerRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), playerRB.velocity.y);

        if (Input.GetButtonDown("Jump"))
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpSpeed);

    }
}
