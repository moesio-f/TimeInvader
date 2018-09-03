using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour 
{
	[SerializeField] int size;
	[SerializeField] GameObject pooledObject;
	private List<GameObject> pool;

	void Start () 
	{
		pool = new List<GameObject>();
		for(int i = 0; i < size; i++)
		{
			Create();
		}
	}
	
	public void Create()
	{
		pool.Add(Instantiate(pooledObject, this.transform));
		pool[pool.Count - 1].SetActive(false);
	}

}
