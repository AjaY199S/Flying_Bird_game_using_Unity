using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<bird_controler> () != null) 
		{
			Game_contoler.instance.BirdScore ();
		}
		
	}
}
