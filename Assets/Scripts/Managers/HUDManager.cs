using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

<<<<<<< HEAD
public class HUDManager : MonoBehaviour {
=======
public class HUDManager : MonoBehaviour 
{
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a

	public Text life;
	public HealthController player;
	
	void Update () 
	{
		life.text = "Vida: " + player.GetCurrent();
	}
}
