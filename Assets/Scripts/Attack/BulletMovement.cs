using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class BulletMovement : MonoBehaviour 
{

	[SerializeField] private PlayerController player;
	[SerializeField] private float speed = 5f;
	private Rigidbody2D rbBullet;

	void OnEnable()
	{
		if(rbBullet == null)
			rbBullet = GetComponent<Rigidbody2D>();

		rbBullet.velocity = new Vector2(speed,0) * this.transform.localScale.x;
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		rbBullet.velocity = new Vector2(0f,0);
		gameObject.SetActive(false);
	}
}
