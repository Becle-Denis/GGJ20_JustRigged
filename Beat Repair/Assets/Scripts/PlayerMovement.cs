using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float hozizontalSpeed = 20f;
    public float jumpForce = 100f;
    public Rigidbody2D rigidbody;
    public LayerMask layerMask;
    private CapsuleCollider2D capsuleCollider;

    private float horizontalnput = 0f;
    private float horizontalVelocity = 0f;
    private int groundEnteringCollision = 0;
    private bool jump = false;
    private bool onGround = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            groundEnteringCollision++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            groundEnteringCollision--;
        }
    }

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalnput = Input.GetAxisRaw("Horizontal");
        horizontalVelocity = horizontalnput * hozizontalSpeed;
        transform.position += Vector3.right * horizontalVelocity * Time.deltaTime;
        onGround = groundEnteringCollision > 0;
        if (Input.GetButton("Jump") && onGround)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            jump = false;
            rigidbody.AddForce(new Vector2(0, jumpForce));
        }
    }
}
