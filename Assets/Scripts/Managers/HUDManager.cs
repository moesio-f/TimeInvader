﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour 
{

	public Text life;
	public HealthController player;
	
	void Update () 
	{
		life.text = "Vida: " + player.GetCurrent();
	}
}
