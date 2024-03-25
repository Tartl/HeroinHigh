using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float runSpeed = 2f;
    private Vector2 moveDirection;
    private bool m_FacingRight = true;

    public PlayerControls playerControls;
    private InputAction move;
    private void Awake()
    {
        playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();
    }
    private void OnDisable()
    {
        move.Disable();
    }
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            animator.SetFloat("SpeedX", 0);
            animator.SetBool("MovingUp",false);
            return;
        }
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
        if(moveDirection.y > 0 && moveDirection.x == 0)
        {
            animator.SetBool("MovingUp",true);
        }
        else
        {
            animator.SetBool("MovingUp",false);
        }
        if(moveDirection.y < 0 && moveDirection.x == 0)
        {
            animator.SetBool("MovingDown",true);
        }
        else
        {
            animator.SetBool("MovingDown",false);
        }
        animator.SetFloat("SpeedX",Math.Abs(moveDirection.x));
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
    private void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180, 0f);
    }
}