using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBalance : MonoBehaviour
 {
	[SerializeField] int amountShootsReference;
	[SerializeField] List<float> timeReferenceByLevel;
	[SerializeField] private PlayerData myPlayerData;
	[SerializeField] private EnemyData bossEnemyData;
 
	void Awake() 
	{
		Debug.Log("Quantas vezes atirou: " + myPlayerData.ShootedBullets());
		if(myPlayerData.ShootedBullets() <= amountShootsReference)
		{
			bossEnemyData.SetValues(speed: Mathf.Clamp((amountShootsReference - myPlayerData.ShootedBullets()), 4, 6));
			Debug.Log("Jogando bem, velocidade do boss: " + bossEnemyData.MovSpeed());
		}
		else
		{
			bossEnemyData.SetValues(speed: Mathf.Clamp((myPlayerData.ShootedBullets() - amountShootsReference), 2, 3));
			Debug.Log("Jogando mal, velocidade do boss: " + bossEnemyData.MovSpeed());
		}
	}

}
// - Quantidade de Vida
// 	+ Tempo para passar de fase 
// - Velocidade de Ataque
// 	+ Precisão(Balas atiradas, Balas acertadas)
// - Dano que ele dá
// 	+ Quanto o personagem recuperou de vida
// - Cooldown entre habilidades(Fases de ataque)
// 	+  Tempo para passar de fase
// 	+  Balas atiradas
// - % De Bloqueio
// 	+ Balas atiradas
// * Pesquisa sobre balanceamento <--
// * Dano por bala(Visualmente)
// -----------------------------------------------//