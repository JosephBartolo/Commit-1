﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {
	private Rigidbody2D rb;



	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			rb.velocity = new Vector2 (0f, 198f);
		} else if (Input.GetKey (KeyCode.S)) {
			rb.velocity = new Vector2 (0f, -198f);
		} else {
			rb.velocity = new Vector2 (0f, 0f);
		}
		
	}
}
