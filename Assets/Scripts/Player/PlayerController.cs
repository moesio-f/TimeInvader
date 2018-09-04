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
	[SerializeField]private SpriteRenderer rend;
	private float x;
	private Rigidbody2D rigid;
	private bool jumpPress;
	private bool onGround = false;
	private bool rightDir = true;
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
			if(rightDir)
			{
				anim.Play("Attack");
			}
			else
			{
				anim.Play("AttackLeft");
			}
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
		if(rigid.velocity.x > 0)
		{
			rend.flipX = false;
			rightDir = false;
		}
		else if(rigid.velocity.x < 0)
		{
			rend.flipX = true;
			rightDir = true;
		}
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

	public float GetVelX()
	{
		return rigid.velocity.x;
	}
}
