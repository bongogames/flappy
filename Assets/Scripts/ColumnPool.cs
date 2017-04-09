﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

	public int columnPoolSize = 5;
	public float spawnRate = 4f;
	public GameObject columnPrefab;
	public float columnMin = -1f;
	public float columnMax = -3.5f;
	private float spawnX = 10f;
	private int currentColumn = 0;

	private GameObject[] columns;

	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);
	private float timeSinceLastSpawn;

	// Use this for initialization
	void Start () {
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++) {
			columns [i] = Instantiate (columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;
		if (!GameControl.instance.gameOver && timeSinceLastSpawn >= spawnRate) {
			timeSinceLastSpawn = 0;

			float spawnY = Random.Range (columnMin, columnMax);

			columns[currentColumn].transform.position = new Vector2 (spawnX, spawnY);			
			currentColumn++;
			if (currentColumn >= columnPoolSize)
				currentColumn = 0;
		}
	}
}
