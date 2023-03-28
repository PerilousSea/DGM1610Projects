using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float jumpForce;
    [Header("Player Jump")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;
    

    private Rigidbody2D _rigidbody;
    private void Start()   
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Update()  
    {
       var movement = Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
       if (!Mathf.Approximately(0, movement))
       {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            
       }
       if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
       {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
       }
    
        if(isGrounded)
        {
            doubleJump = true;
        }
        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            _rigidbody.velocity = Vector2.up * jumpForce;
            doubleJump = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) &&  !doubleJump && isGrounded)
        {
            _rigidbody.velocity = Vector2.up * jumpForce;
        }
       
    }
     void FixedUpdate()
    {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    /*
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
        //transform.localScale = scaler;
        transform.Rotate(0f, 180f, 0f);
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

    */
}
