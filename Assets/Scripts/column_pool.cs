using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column_pool : MonoBehaviour {

	public int columnsize = 5;
	public GameObject columnPrefab;
	public float Swaprate = 4f;
	public float min = -1f;
	public float max = 3.5f;

	private GameObject[] columns;
	private Vector2 objpoolposi = new Vector2 (-15f, -25f);
	private float TimeSinceLastSpawned;
	private float spawnXPosition = 10f;
	private int currentcolumn;

	// Use this for initialization
	void Start () {
		columns = new GameObject[columnsize];
		for (int i = 0; i < columnsize; i++) 
		{
			columns [i] = (GameObject)Instantiate (columnPrefab, objpoolposi, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		TimeSinceLastSpawned += Time.deltaTime;
		if (Game_contoler.instance.gameOver == false && TimeSinceLastSpawned >= Swaprate) 
		{
			TimeSinceLastSpawned = 0;
			float spawnYPosition = Random.Range (min, max);
			columns [currentcolumn].transform.position = new Vector2 (spawnXPosition, spawnYPosition);
			currentcolumn++;
			if (currentcolumn >= columnsize) 
			{
				currentcolumn = 0;
			}


		}
		
	}
}
