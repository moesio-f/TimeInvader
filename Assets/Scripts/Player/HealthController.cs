using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class HealthController : MonoBehaviour {
=======
public class HealthController : MonoBehaviour 
{
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a

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
<<<<<<< HEAD
			Debug.Log ("Passou pela corotina");
			if (current < amount) {
=======
			if (current < amount) 
			{
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
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
<<<<<<< HEAD
		if(collis.collider.CompareTag("Bullet"))
=======
		if(collis.collider.CompareTag("Enemy"))
>>>>>>> 76c8df02930bb985c647aa709fd626a1c0c58d7a
		{
			Damage(1);
		}
	}

	public int GetCurrent() // Obtém o valor da Vida atual
	{
		return current;
	}
}
