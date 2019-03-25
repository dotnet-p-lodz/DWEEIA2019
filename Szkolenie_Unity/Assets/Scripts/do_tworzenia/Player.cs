using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Animator anim;
	private Rigidbody2D rb2d;

	void Start(){
		
		anim = gameObject.GetComponent<Animator> ();
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update(){
		
		anim.SetFloat ("speed", Mathf.Abs (rb2d.velocity.x));
		anim.SetFloat ("ySpeed", Mathf.Abs (rb2d.velocity.y));

		if (gameObject.GetComponent<KeyboardMovement> ().Horizontal < 0) {
			gameObject.transform.GetChild (0).rotation = new Quaternion (0f, 180f, 0f, gameObject.transform.GetChild(0).rotation.w);
		} else if(gameObject.GetComponent<KeyboardMovement> ().Horizontal > 0){
			gameObject.transform.GetChild (0).rotation = new Quaternion (0f, 0f, 0f, gameObject.transform.GetChild(0).rotation.w);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == "Enemy_kill") {
			other.gameObject.transform.parent.gameObject.GetComponent<Killable> ().Kill ();
		}
	}
}