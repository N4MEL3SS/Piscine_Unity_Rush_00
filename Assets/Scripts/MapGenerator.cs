using System;
using UnityEngine;
public class MapGenerator : MonoBehaviour
{
	public Texture2D map;
	public PrefabManager[] manager;

	private void Start()
	{
		Generate();
	}

	private void Generate()
	{
		for(var x = 0; x < map.width; x++)
		{
			for (var y = 0; y < map.height; y++)
				GenerateTile(x, y);
		}
	}

	private void GenerateTile(int x, int y)
	{
		var pixelColor = map.GetPixel(x, y);

		if (pixelColor.a == 0) return;

		foreach (var colors in manager)
		{
			if (colors.color.Equals(pixelColor))
			{
				var position = new Vector2(x, y);
				Instantiate(colors.prefab, position, Quaternion.identity, transform);
			}
		}
	}
}
