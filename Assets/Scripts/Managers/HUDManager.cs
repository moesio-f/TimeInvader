using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour 
{

	[SerializeField]private Text life;
	[SerializeField]private Text parts;
	[SerializeField]private HealthController player;
	
	void Update () 
	{
		life.text = "Vida: " + player.GetCurrent();
		parts.text = "x" + Collectables.partsCollecteds + "/5";
	}
}