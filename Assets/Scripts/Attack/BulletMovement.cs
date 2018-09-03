using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
public class BulletMovement : MonoBehaviour {

	public Vector2 speed = new Vector2 (5, 0);
	private Rigidbody2D rbBullet;

	void Start () 
	{
		rbBullet = GetComponent<Rigidbody2D>();
		rbBullet.velocity = speed * this.transform.localScale.x;
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		gameObject.SetActive(false);
	}
}
