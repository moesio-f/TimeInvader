using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BulletSpawn : MonoBehaviour 
{
	[SerializeField] int size;
	[SerializeField] GameObject pooledObject;
	[SerializeField] Transform playerTransform;
	[SerializeField] float reloadTime;
	private List<GameObject> pool;
	private bool canShoot = true;

	void Start () 
	{
		pool = new List<GameObject>();
		for(int i = 0; i < size; i++)
		{
			Create();
		}

	}

	void Update()
	{
		if(CrossPlatformInputManager.GetButtonDown("Fire2") && canShoot)
		{
			Spawn(playerTransform).SetActive(true);
			StartCoroutine(Reload(reloadTime));
		}
	}

	public void Create()
	{
		pool.Add(Instantiate(pooledObject, this.transform));
		pool[pool.Count - 1].SetActive(false);
		BulletMovement.StartBulletShooted();
	}

	public GameObject Spawn(Transform playerPos)
	{
		for(int i = 0; i < pool.Count; i++)
		{
			if(!pool[i].activeSelf)
			{
				pool[i].transform.position = playerPos.position;
				return pool[i];
			}
		}
		return null;
	}

	IEnumerator Reload(float reloadTime)
	{
		canShoot = false;
		yield return new WaitForSeconds(reloadTime);
		canShoot = true;
	}

}
