using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_contoler : MonoBehaviour {

	public static Game_contoler instance;

	public Text Scoretext;
	public GameObject gameOverText;
	public bool gameOver = false;
	public float game_scoller = -1.5f;

	private int score = 0;

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameOver == true && Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
		
	}
	public void BirdDie()
	{
		gameOverText.SetActive (true);
		gameOver = true; 
		
	}
	public void BirdScore ()
	{
		if (gameOver) {
			return;
		}
		score++;
		Scoretext.text = "Score : " + score.ToString ();
	}
}
