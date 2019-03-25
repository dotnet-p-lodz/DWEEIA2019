using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

	public GameObject winningScreen;
	private GameOver gOver;

	void Start () {
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			winningScreen.SetActive (true);
			gOver.playing = false;

		}
	}

}
