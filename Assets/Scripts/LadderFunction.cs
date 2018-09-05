using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class LadderFunction : MonoBehaviour {
	

	public float Speed;
	
	bool PressW;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
		
	}

	void OnTriggerStay2D()
	{
		if(other.tag=="Player" && Input.GetButtonDown("Jump"))
		{

		}
	}
}
