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
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
}