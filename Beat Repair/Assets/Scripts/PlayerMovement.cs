using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float hozizontalSpeed = 20f;
    public float jumpForce = 100f;
    public Rigidbody2D rigidbody;
    public LayerMask groundLayer;

    private float horizontalnput = 0f;
    private float horizontalVelocity = 0f;
    private bool jump = false;
    public GameObject shipContainer;

    
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalnput = Input.GetAxisRaw("HorizontalPlayer");
        horizontalVelocity = horizontalnput * hozizontalSpeed;
        transform.position += Vector3.right * horizontalVelocity * Time.deltaTime;
        if (Input.GetButton("Jump") && isOnGround())
        {
            jump = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            shipContainer.GetComponent<ComponentHandler>().repairing = true;
        }
        else
        {
            shipContainer.GetComponent<ComponentHandler>().repairing = false;
        }
    
    }

    private bool isOnGround()
    {
        return Physics2D.OverlapArea(
            new Vector2(transform.position.x, transform.position.y),
            new Vector2(transform.position.x, transform.position.y - 0.2f),
            groundLayer); ;
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
