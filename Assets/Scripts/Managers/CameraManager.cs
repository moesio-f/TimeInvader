using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour 
{
	[SerializeField] private Vector3 offset;
	[SerializeField] private float smoothTime;
	[SerializeField] private Transform target;
	private float refVel = 0.0f;

	void LateUpdate () 
	{
		transform.position = target.position - offset;
	}
}
