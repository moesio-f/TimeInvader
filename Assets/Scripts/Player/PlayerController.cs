using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerController : MonoBehaviour 
{
	[SerializeField]private SpriteRenderer rend;
	[SerializeField]private PlayerData myPlayerData;
	private float speed, jumpHeight, x;
	private bool jumpPress;
	private bool onGround = false;
	private Rigidbody2D rigid;
	private CapsuleCollider2D colli;
	private Vector2 colliderOffset, vel;


	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
		colli = GetComponent<CapsuleCollider2D>();
		colliderOffset = colli.offset;

		speed = myPlayerData.MovSpeed();
		jumpHeight = myPlayerData.JumpHeight();
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
			vel = new Vector2 (vel.x, jumpHeight * speed);
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
