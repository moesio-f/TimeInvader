using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour 
{
	[SerializeField] private PlayerData myPlayerData;
	private string tagDammage; // Tag que determina para quem ele recebe dano
	private int amount;
	private int current; // Vida atual
	private static bool firstGameplay = true;


	void Start () // Coloca a vida inicial
	{
		amount = myPlayerData.HealtAmount();
		tagDammage = myPlayerData.TagDammaged();

		if(firstGameplay)
		{
			current = amount; // Atribui o valor da vida inicial ao da vida máxima
			firstGameplay = false;
		}
		else
		{
			current = myPlayerData.GetCurrentLife();
		}

		StartCoroutine(Recovery()); // Inicia a coroutina de regeneração
	}

	void Update () // Checa se ele está vivo(Vida > 0)
	{
		if(current <= 0)
		{
			firstGameplay = true;
            UnityEngine.SceneManagement.SceneManager.LoadScene("MenuPrincipal");
		}
	}

	void OnCollisionEnter2D(Collision2D collis) // Colisão com a bala
	{
		if(collis.collider.CompareTag(tagDammage))
		{
			Damage(1);
		}
	}

#region Functions
	public void Damage(int value) // Receber dano
	{
		current -= value;
	}

	public void Heal(int value) // Recuperar vida
	{
		current += value;
	}

	public int GetCurrent() // Obtém o valor da Vida atual
	{
		return current;
	}
	public void FullHealth() // Reseta o valor da vida
	{
		current = amount;
	}

		IEnumerator Recovery() // Coroutina para recuperar vida
	{
		yield return new WaitForSeconds(myPlayerData.RecoveryHealthTime());
		while (true) 
		{
			if (current < amount) 
			{
				Heal (1);
			}
			yield return new WaitForSeconds(myPlayerData.RecoveryHealthTime());
		}
	}
	#endregion Functions
}
