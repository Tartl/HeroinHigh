using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runSpeed = 2f;
    float horizontalMove = 0f;
    float verticalMove = 0f;

    private Vector2 moveDirection;
    private bool m_FacingRight = true;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;

        moveDirection = new Vector2(horizontalMove * Time.fixedDeltaTime, verticalMove * Time.fixedDeltaTime).normalized;
    }

    public void Stop()
    {
        GetComponent<PlayerMovement>().runSpeed = 0f;
    }

    public void Go()
    {
        GetComponent<PlayerMovement>().runSpeed = 25f;
    }

    private void FixedUpdate()
    {
        if (moveDirection.x < 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (moveDirection.x > 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
    private void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180, 0f);
    }
}