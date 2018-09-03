using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerController : MonoBehaviour 
{
	[SerializeField] private float speed;
	[SerializeField] private float jumpHeight;
	[SerializeField] private Animator anim;
	private float x;
	private Rigidbody2D rigid;
	private bool jumpPress;
	private bool onGround = false;
	private Vector2 vel;

	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
	}

	void Update() 
	{
		x = CrossPlatformInputManager.GetAxis("Horizontal");
		jumpPress = CrossPlatformInputManager.GetButton("Jump");
		
		if(CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			anim.Play("Attack");
			anim.SetBool("meleeAttack", true);
		}
		else if(CrossPlatformInputManager.GetButtonUp("Fire1"))
		{
			anim.SetBool("meleeAttack", false);

		}
	}

	void FixedUpdate()
	{
		vel = new Vector2(x * speed, rigid.velocity.y);
		if(jumpPress && onGround)
		{
			vel += new Vector2 (0, jumpHeight);
		}

		rigid.velocity = vel;
	}

	void OnCollisionEnter2D(Collision2D point)
	{
		if(point.gameObject.CompareTag("Ground"))
		{
			onGround = true;
		}
	}

	void OnCollisionExit2D(Collision2D point)
	{
		if(point.gameObject.CompareTag("Ground"))
		{
			onGround = false;
		}
	}
}
