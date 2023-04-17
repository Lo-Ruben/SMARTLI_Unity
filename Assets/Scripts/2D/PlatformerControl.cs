using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerControl : MonoBehaviour
{
    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    float walkSpeed = 10f;
    float jumpPower = 20f;
    Rigidbody2D rbPlayer;
    BoxCollider2D boxCollider;
    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        rbPlayer.velocity = new Vector2(Input.GetAxis("Horizontal") * walkSpeed, rbPlayer.velocity.y);
        
        if (Input.GetKeyDown("space") && IsGrounded())
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x , jumpPower);
        }
    }
    bool IsGrounded()
    {
        return Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down,0.1f, groundLayer);

    }
}

