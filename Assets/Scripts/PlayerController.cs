using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator playerAnimator;

    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        //for sprite movement direction
        if (Input.GetKeyDown(KeyCode.W))
            {
                playerAnimator.SetBool("moveUp", true);
            }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerAnimator.SetBool("moveUp", true);
            }
        else if (Input.GetKeyUp(KeyCode.W))
            {
                playerAnimator.SetBool("moveUp", false);
            }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                playerAnimator.SetBool("moveUp", false);
            }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnimator.SetBool("moveDown", true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerAnimator.SetBool("moveDown", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("moveDown", false);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            playerAnimator.SetBool("moveDown", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playerAnimator.SetBool("moveLeft", true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerAnimator.SetBool("moveLeft", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            playerAnimator.SetBool("moveLeft", false);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            playerAnimator.SetBool("moveLeft", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerAnimator.SetBool("moveRight", true);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerAnimator.SetBool("moveRight", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            playerAnimator.SetBool("moveRight", false);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            playerAnimator.SetBool("moveRight", false);
        }

        //player input to trigger movement
        ProcessInputs();
    }

    void FixedUpdate()
    {
        //actual player movement, physics calculations, etc
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY); // TODO come back to this
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

}
