using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    public float jumpPower = 100;
    bool grounded;

    SpriteRenderer sr;
    Rigidbody2D rb;
    Animator anim;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            sr.flipX = true;
        }

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpPower));
        }

        anim.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
    }



    void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            grounded = true;
            anim.SetBool("Grounded", true);
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        grounded = false;
        anim.SetBool("Grounded", false);
    }
}