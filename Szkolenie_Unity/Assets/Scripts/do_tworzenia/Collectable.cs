using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	[Header("Ilość punktów za zebranie")]
	public int scoreToAdd = 1;

	void FixedUpdate(){
		//poruszanie sie gora/dol w zaleznosci od fcji sin
		transform.Translate (Vector2.up * 0.008f * Mathf.Sin (Time.time*5));
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			GameObject.Find ("Points").GetComponent<PointsHandler> ().AddScore (scoreToAdd);
			Destroy (gameObject);
		}
	}
}
