using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collectables : MonoBehaviour 
{
	public int typeBehaviour = 0;
	public static int partsCollecteds{ get; private set; }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(typeBehaviour == 0 && other.CompareTag("Player"))
		{
			partsCollecteds++;
			gameObject.SetActive(false);
			if(partsCollecteds == 5)
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene("MenuPrincipal");
			}
		}
	}

    public static void TurnZero()
    {
        partsCollecteds = 0;
    }
}
