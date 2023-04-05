using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


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
    
    public Animator animator;
    [Header("Events")]

	public UnityEvent OnLandEvent;

	[System.Serializable]
	public class BoolEvent : UnityEvent<bool> { }

    private Rigidbody2D _rigidbody;
    private void Start()   
    {
        _rigidbody = GetComponent<Rigidbody2D>();
      if (OnLandEvent == null)
        {
            OnLandEvent = new UnityEvent();
        }
    }
    public void Move(float move, bool jump)
	{
		var movement = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movement));
       
       // horizontalMove = Input.GetAxis("Horizontal");
       //var movement = Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
       if (!Mathf.Approximately(0, movement))
       {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            
       }
       if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
       {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
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
		
	

   /* private void Update()  
    {
        var movement = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(movement));
       
       // horizontalMove = Input.GetAxis("Horizontal");
       //var movement = Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
       if (!Mathf.Approximately(0, movement))
       {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
            
       }
       if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
       {
            _rigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
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
    */
     public void OnLanding()
        {
        animator.SetBool("IsJumping", false);
        } 
     void FixedUpdate()
        {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        }
}


