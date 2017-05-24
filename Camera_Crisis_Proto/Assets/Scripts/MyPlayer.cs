using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour {

	public float maxSpeed = 10f ;
	public float jumpForce = 700f ;
	private bool facingRight = true ;

	private bool grounded = false ;
	public Transform groundCheck ;
	float groundRadius = 0.2f ;
	public LayerMask whatIsGround ;

	void FixedUpdate()
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround) ;

		float move = Input.GetAxis("Horizontal") ;

		GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y) ;

		if(move > 0 && !facingRight)
		{
			Flip() ;
		}
		else if(move<0 && facingRight)
		{
			Flip() ;
		}
	}

	void Update()
	{
		if(grounded && Input.GetKeyDown(KeyCode.Space))
		{
		 GetComponent<Rigidbody2D>().AddForce(new Vector2(0,jumpForce)) ;
		}
	}

	void Flip()
	{
		facingRight = !facingRight ;

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.GetComponent<Object_Application>())
		{
			other.GetComponent<Object_Application>().Application() ;
		}
	}
}
