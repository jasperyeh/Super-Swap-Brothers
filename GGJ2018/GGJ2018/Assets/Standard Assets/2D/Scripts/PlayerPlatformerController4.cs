using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController4 : PhysicsObject2
{

    public float maxSpeed = 7;
    public float gravity = 7f;
    public float jumpTakeOffSpeed = 7;
    private bool canDoubleJump = false;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal4");

        if (Input.GetButtonDown("Jump4") && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
            canDoubleJump = true;
        }
        else 
        {
            if (canDoubleJump && Input.GetButtonDown("Jump4"))
            {
                velocity.y = jumpTakeOffSpeed*1.2f;
                canDoubleJump = false;
            }
            velocity.y -= gravity * Time.deltaTime * 1.6f;
        }
        
        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        targetVelocity = move * maxSpeed;
    }
}
 