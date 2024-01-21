using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private bool IsTouching;
    public float jumpForce = 15f;
    private float jumpTime = 0f;
    private float maxJumpTime = 1.5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        if (IsTouching)
        {
            if (Input.GetKeyDown("space"))
            {
                jumpTime = 0f;
            }
            if (Input.GetKey("space") && jumpTime < maxJumpTime)
            {
                jumpTime += Time.deltaTime;
            }
            if (Input.GetKeyUp("space"))
            {
                Jump();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground"))
        {
            IsTouching = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("ground"))
        {
            IsTouching = false;
        }
    }
    private void Jump()
    {
        float calculatedJumpForce = Mathf.Min(jumpForce + (jumpTime * 12f), 28f);

        rb.velocity = new Vector2(rb.velocity.x, calculatedJumpForce);
    }

}
