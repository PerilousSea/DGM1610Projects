using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("Player Stats")]
    public float speed;
    public float jumpForce;
    private float moveInput;
    [Header("Rigidbody Component")]
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    [Header("Player Jump")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
       moveInput = Input.GetAxis("Horizontal");
       rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if(isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }
        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }
    
    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }

 // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }
        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce;
            doubleJump = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) &&  !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }


}
