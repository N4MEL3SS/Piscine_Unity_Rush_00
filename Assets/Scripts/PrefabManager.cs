using System;
using UnityEngine;

[System.Serializable]
public class PrefabManager : MonoBehaviour
{
	public Color color;
	
	public GameObject prefabSprite;

	private void Start()
	{
		prefabSprite = GameObject.FindGameObjectWithTag("Tiles");
		color.a = 1;
	}
}
