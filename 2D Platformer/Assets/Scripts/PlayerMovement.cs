using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{

	public PlayerController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool walking = false;

	// Update is called once per frame
	void Update () 
	{

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("IsJumping", true);

		}
		else if (Input.GetButtonDown("Horizontal"))
		{
			walking = true;
			animator.SetBool("IsWalking", true);
		}
		else
		{
			jump = false;
			animator.SetBool("IsJumping", false);
		}
		
	}

	public void OnLanding ()
	{
		animator.SetBool("IsJumping", false);
	}


	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
	}
}
