using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			
				rb.velocity = new Vector2 (0f, 2500f);

		} else if (Input.GetMouseButtonDown (1)) {

				rb.velocity = new Vector2 (0f, -2500f);
			
		} else {
			rb.velocity = new Vector2 (0f, 0f);
		}
		
	}
}
