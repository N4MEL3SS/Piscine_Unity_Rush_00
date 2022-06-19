using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnerManager : MonoBehaviour
{
	public GameObject[] spawnerPointsMassive;
	public GameObject[] enemyPrefabs;

	public float[] spawnerDirection;

	private void Start()
	{
		Spawn();
	}

	private void Spawn()
	{
		foreach (var spawnPoint in spawnerPointsMassive)
		{
			Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], spawnPoint.transform.position, 
				Quaternion.identity);
		}
	}
}
