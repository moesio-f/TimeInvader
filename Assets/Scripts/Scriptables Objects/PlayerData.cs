using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject 
{
	#region Pattern
	[SerializeField] private int healthAmount;
	[SerializeField] private float recoveryHealthTime;
	[SerializeField] private float movSpeed;
	[SerializeField] private float jumpHeight;
	[SerializeField] private string tagDammaged;
	#endregion Pattern

	#region Variant
	[SerializeField] private int healthCurrent;
	[SerializeField] private int partsCollecteds;
	[SerializeField] private int shootedBullets;
	[SerializeField] private List<float> playedTime;
	#endregion Variant

	public void ResetAllValues()
	{
		healthCurrent = 0;
		partsCollecteds = 0;
		shootedBullets = 0;
		playedTime.Clear();
	}

	public void SetValues(int current = -1, int parts = -1, int shoots = -1, float time = -1f)
	{
		healthCurrent = (current > -1) ? current : healthCurrent;
		partsCollecteds = (parts > -1) ? parts : partsCollecteds;
		shootedBullets = (shoots > -1) ? shoots : shootedBullets;
		if(time > -1f)
			playedTime.Add(time);
	}

	#region Getters

		#region Variants
	public int GetCurrentLife()
	{
		return healthCurrent;
	}
	public int GetNumOfCollectedParts()
	{
		return partsCollecteds;
	}
	public int ShootedBullets()
	{
		return shootedBullets;
	}
	public List<float> PlayedTime()
	{
		return playedTime;
	}
		#endregion Variants

		#region Patterns
		public int HealtAmount()
		{
			return healthAmount;
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
		#endregion Patterns

	#endregion Getters
}
