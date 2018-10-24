using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EnemyData", menuName = "Enemy Data")]
public class EnemyData : ScriptableObject 
{
	[SerializeField] private int healthAmount;
	[SerializeField] private int damageAmount;
	[SerializeField] private float recoveryHealthTime;
	[SerializeField] private float movSpeed;
	[SerializeField] private float jumpHeight;
	[SerializeField] private string tagDammaged;

	public void SetValues(int amount = -1, int damage = -1, float recoveryTime = -1, float speed = -1, float jump = -1f)
	{
		healthAmount = (amount > -1) ? amount : healthAmount;
		damageAmount = (damage > -1) ? damage : damageAmount;
		recoveryHealthTime = (recoveryHealthTime > -1f) ? recoveryTime : recoveryHealthTime;
		movSpeed = (speed > -1f) ? speed : movSpeed;
		jumpHeight = (jump > -1f) ? jump : jumpHeight;

	}

	#region Getters
		public int HealtAmount()
		{
			return healthAmount;
		}
		public int DamageAmount()
		{
			return damageAmount;
		}
		public float RecoveryHealthTime()
		{
			return recoveryHealthTime;
		}
		public float MovSpeed()
		{
			return movSpeed;
		}
		public float JumpHeight()
		{
			return jumpHeight;
		}
		public string TagDammaged()
		{
			return tagDammaged;
		}
		#endregion Getters
}
