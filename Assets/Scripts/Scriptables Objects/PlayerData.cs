using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject 
{
	[SerializeField]
    private int healthCurrent;
	[SerializeField]
	private int partsCollecteds;
	[SerializeField]
	private int shootedBullets;
	[SerializeField]
	private float playedTime;

	public void ResetAllValues()
	{
		healthCurrent = 0;
		partsCollecteds = 0;
		shootedBullets = 0;
		playedTime = 0;
	}

	public void SetValues(int current = -1, int parts = -1, int shoots = -1, float time = -1f)
	{
		healthCurrent = (current > -1) ? current : healthCurrent;
		partsCollecteds = (parts > -1) ? parts : partsCollecteds;
		shootedBullets = (shoots > -1) ? shoots : shootedBullets;
		playedTime = (time > -1f) ? time : playedTime;
	}

	#region Getters
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
	public float PlayedTime()
	{
		return playedTime;
	}

	#endregion Getters
}
