using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsHandler : MonoBehaviour {

	public int score;

	private Text scoreText;

	void Start () {
		score = 0;
		scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		scoreText.text = score.ToString ();
	}
	
	public void AddScore(int amount){
		score += amount;
		scoreText.text = score.ToString ();
	}

}
