using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    float verticalMove = 0f;

    private Vector2 moveDirection;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        verticalMove = Input.GetAxisRaw("Vertical") * runSpeed;

        moveDirection = new Vector2(horizontalMove, verticalMove);  
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove + verticalMove));
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
        //Moving our character
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
}
