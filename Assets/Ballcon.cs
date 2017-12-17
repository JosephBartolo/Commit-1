using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcon : MonoBehaviour {
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (200f, 200f);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x >= 1029f) {
			this.transform.position = new Vector3 (2f,-3f,0f);
		}
		if (this.transform.position.x <= -1029f) {
			this.transform.position = new Vector3 (2f,-3f,0f);
		}
		
	}
}
