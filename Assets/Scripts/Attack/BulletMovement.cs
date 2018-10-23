using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class BulletMovement : MonoBehaviour 
{


	[SerializeField] private float speedRef = 5f;

	private SpriteRenderer playerRend;

	private Rigidbody2D rbBullet;
	private float positiveSpeed;
	private float negativeSpeed;
	private float finalSpeed;


	void OnEnable()
	{
		positiveSpeed = speedRef;
		negativeSpeed = speedRef * -1;
		if(rbBullet == null)
			rbBullet = GetComponent<Rigidbody2D>();

		if(playerRend == null)
			playerRend = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
		
		if(playerRend.flipX)
		{
			finalSpeed = negativeSpeed;
		}
		else
		{
			finalSpeed = positiveSpeed;
		}

		rbBullet.velocity = new Vector2(finalSpeed,0) * this.transform.localScale.x;
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		rbBullet.velocity = new Vector2(0f,0);
		gameObject.SetActive(false);
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        rbBullet.velocity = new Vector2(0f, 0);
        gameObject.SetActive(false);
    }

}
