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
        if (!PauseMenu.isPaused)
        {
            moveDirection = move.ReadValue<Vector2>();
        }
        else
        {
            moveDirection = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            animator.SetFloat("SpeedX", 0);
            animator.SetBool("MovingUp", false);
            return;
        }

        if (PauseMenu.isPaused)
        {
            rb.velocity = Vector2.zero;
            return;
        }

        if (moveDirection.x < 0 && m_FacingRight)
        {
            Flip();
        }
        else if (moveDirection.x > 0 && !m_FacingRight)
        {
            Flip();
        }

        if (moveDirection.y > 0 && moveDirection.x == 0)
        {
            animator.SetBool("MovingUp", true);
        }
        else
        {
            animator.SetBool("MovingUp", false);
        }

        if (moveDirection.y < 0 && moveDirection.x == 0)
        {
            animator.SetBool("MovingDown", true);
        }
        else
        {
            animator.SetBool("MovingDown", false);
        }

        animator.SetFloat("SpeedX", Mathf.Abs(moveDirection.x));
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}