using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAndExitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChsngeSceen(string Scan )
	{
		Application.LoadLevel (Scan);
	}
	public void Exit_game()
	{
		Debug.Log ("Game out");
		Application.Quit ();
	}
}
