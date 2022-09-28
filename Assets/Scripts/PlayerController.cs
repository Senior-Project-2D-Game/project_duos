using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed, jumpForce;
    public Rigidbody2D rb;
    public Transform groundPoint;
    public LayerMask whatIsGround;
    private bool isGrounded;
    private float inputX;

    void Start()
    {

    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPoint.position, .2f, whatIsGround);
        // Horizontal movement
        rb.velocity = new Vector2(inputX * moveSpeed, rb.velocity.y);

    }

    public void Move(InputAction.CallbackContext context)
    {
        // Horizontal movement 
        inputX = context.ReadValue<Vector2>().x;
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
}
