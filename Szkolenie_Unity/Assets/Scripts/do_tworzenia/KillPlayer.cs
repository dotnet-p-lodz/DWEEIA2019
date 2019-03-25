using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	private GameOver gOver;

	public GameObject deathParticles;

	void Start(){
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Player") {
			Instantiate (deathParticles, gameObject.transform.position, gameObject.transform.rotation);
			coll.gameObject.GetComponent<Killable> ().Kill ();
			gOver.Defeat ();
		}
		
	}
}
