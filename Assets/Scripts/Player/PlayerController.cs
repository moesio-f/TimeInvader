using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class PlayerController : MonoBehaviour 
{
	[SerializeField] private float speed;
	[SerializeField] private float jumpHeight;
<<<<<<< HEAD
	[SerializeField] private Animator anim;
	private float x;
	private Rigidbody2D rigid;
=======
	[SerializeField]private SpriteRenderer rend;
	private float x;
	private Rigidbody2D rigid;
	private CapsuleCollider2D colli;
	private Vector2 colliderOffset; // <-- SOLUÇÃO pae
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
	private bool jumpPress;
	private bool onGround = false;
	private Vector2 vel;

<<<<<<< HEAD
	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
=======

	void Start () 
	{
		rigid = GetComponent<Rigidbody2D>();
		colli = GetComponent<CapsuleCollider2D>();
		colliderOffset = colli.offset;
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
	}

	void Update() 
	{
		x = CrossPlatformInputManager.GetAxis("Horizontal");
		jumpPress = CrossPlatformInputManager.GetButton("Jump");
<<<<<<< HEAD
		if(CrossPlatformInputManager.GetButtonDown("Fire1"))
		{
			print("Oao");
			anim.SetBool("XD", true);
		}
		else if(CrossPlatformInputManager.GetButtonUp("Fire1"))
		{
			print("123124ao");
			anim.SetBool("XD", false);

		}
	}

=======
	}
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
	void FixedUpdate()
	{
		vel = new Vector2(x * speed, rigid.velocity.y);
		if(jumpPress && onGround)
		{
			vel += new Vector2 (0, jumpHeight);
		}

		rigid.velocity = vel;
<<<<<<< HEAD
=======
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
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
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
<<<<<<< HEAD
=======


>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
}
