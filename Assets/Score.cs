using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
	public Text Scoreboard;
	public GameObject ball;
	private int Player1=0;
	private int Player2=0;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find ("ball");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ball.transform.position.x >= 1029f) {
			Player1++;
		}
		if (ball.transform.position.x <= -1029f) {
			Player2++;
		}
		Scoreboard.text = Player1.ToString () + "-" + Player2.ToString ();
		print (Player1 + "," + Player2);


		for (int i = 1; i <= 3; i++) 
		{
			if (Player1 == 5) {
				SceneManager.LoadScene (i);
			} else if (Player2 == 5) {
				SceneManager.LoadScene (i);
			}
		}

		if (Player1 == 15)
		{
			SceneManager.LoadScene (4);
		}
		else if(Player2 == 15)
		{
			SceneManager.LoadScene (5);
		}
	}
}
