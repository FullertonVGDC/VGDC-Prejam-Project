using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1;
    public float jumpPower = 100;
    bool grounded;

    public AudioClip jumpSound;

    SpriteRenderer sr;
    Rigidbody2D rb;
    Animator anim;
    AudioSource audioSource;



    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
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
            audioSource.clip = jumpSound;
            audioSource.Play();
        }

        anim.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));

        if (transform.position.y < -30)
        {
            transform.position = new Vector2(0, 0);
            rb.velocity = new Vector2(0, 0);
        }
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