using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float runSpeed = 2.5f;
    private Vector2 moveDirection;
    private bool m_FacingRight = true;

    public PlayerControls playerControls;
    private InputAction move;
    private InputAction interact;
    private void Awake()
    {
        playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        move = playerControls.Player.Move;
        move.Enable();

        interact = playerControls.Player.Interact;
        interact.Enable();

    }
    private void OnDisable()
    {
        move.Disable();
        interact.Disable();
    }
    void Update()
    {
        moveDirection = move.ReadValue<Vector2>();
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
        if(DialogueManager.GetInstance().dialogueIsPlaying)
        {
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
        rb.velocity = new Vector2(moveDirection.x * runSpeed, moveDirection.y * runSpeed);
    }
    private void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180, 0f);
    }
    public void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("Interakce");
    }
}