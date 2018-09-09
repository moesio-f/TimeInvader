using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour 
{
	[SerializeField] private Vector3 offset;
	[SerializeField] private float smoothTimeX;
	[SerializeField] private float smoothTimeY;
	[SerializeField] private Transform target;
	[SerializeField] private Transform maxPos;
	private Vector2 Velocity;
	private float posX, posY;

	void FixedUpdate()
	{
		posX = Mathf.SmoothDamp(transform.position.x, target.position.x, ref Velocity.x, smoothTimeX);
		posY = Mathf.SmoothDamp(transform.position.y, target.position.y, ref Velocity.y, smoothTimeY);
		
		transform.position = new Vector3(posX, posY, transform.position.z) - offset;
	}
}
