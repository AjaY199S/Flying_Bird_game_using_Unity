using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_controler : MonoBehaviour {
	public float upforce = 200f;

	private bool dead = false;
	private Rigidbody2D rb2d;
	private Animator amin;
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		amin = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (dead == false) 
		{
			if (Input.GetMouseButtonDown (0)) 
			{
				rb2d.velocity = Vector2.zero;
				rb2d.AddForce (new Vector2 (0, upforce));
				amin.SetTrigger ("anmi3");
			}
		}
	}

	void OnCollisionEnter2D()
	{
		rb2d.velocity = Vector2.zero;
		dead = true;
		amin.SetTrigger ("anmi2");
		Game_contoler.instance.BirdDie();
	}
}
