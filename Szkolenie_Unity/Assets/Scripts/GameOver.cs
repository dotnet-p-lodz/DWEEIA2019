using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	public GameObject loseScreen;
	public bool playing;

	void Start () {
		playing = true;
	}

	public void Defeat(){
		loseScreen.SetActive (true);
		playing = false;
	}

}
