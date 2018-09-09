using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerController : MonoBehaviour 
{
	[SerializeField] private float speed;
	[SerializeField] private float jumpHeight;
	[SerializeField]private SpriteRenderer rend;
	private float x;
	private Rigidbody2D rigid;
	private CapsuleCollider2D colli;
	private Vector2 colliderOffset; // <-- SOLUÇÃO pae
	private bool jumpPress;
	private bool onGround = false;
	private Vector2 vel;


	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
		colli = GetComponent<CapsuleCollider2D>();
		colliderOffset = colli.offset;
	}

	void Update() 
	{
		x = CrossPlatformInputManager.GetAxis("Horizontal");
		jumpPress = CrossPlatformInputManager.GetButton("Jump");
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
			colli.offset = new Vector2(colliderOffset.x, colliderOffset.y);
		}
		else if(rigid.velocity.x < 0)
		{
			rend.flipX = true;
			colli.offset = new Vector2(colliderOffset.x * -1, colliderOffset.y);
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


}
