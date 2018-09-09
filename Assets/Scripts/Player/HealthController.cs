using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour 
{

	public int amount; // Quantidade de vidas
	public float recoveryTime; // Recuperação de vida

	private int current; // Vida atual

	void Start () // Coloca a vida inicial
	{
		current = amount; // Atribui o valor da vida inicial ao da vida máxima
		StartCoroutine(Recovery()); // Inicia a coroutina de regeneração
	}

	void Update () // Checa se ele está vivo(Vida > 0)
	{
		if(current <= 0)
		{
			Destroy (this.gameObject);
		}
	}

	IEnumerator Recovery() // Coroutina para recuperar vida
	{
		while (true) 
		{
			if (current < amount) 
			{
				Heal (1);
			}
			yield return new WaitForSeconds(recoveryTime);
		}
	}


	public void Damage(int value) // Receber dano
	{
		current -= value;
	}

	public void Heal(int value) // Recuperar vida
	{
		current += value;
	}


	void OnCollisionEnter2D(Collision2D collis) // Colisão com a bala
	{
		if(collis.collider.CompareTag("Enemy"))
		{
			Damage(1);
		}
	}

	public int GetCurrent() // Obtém o valor da Vida atual
	{
		return current;
	}
}
