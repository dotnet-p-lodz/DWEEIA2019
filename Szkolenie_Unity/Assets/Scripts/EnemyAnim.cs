using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour {

	private Animator anim;
	private Rigidbody2D rb2d;

	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		rb2d = gameObject.GetComponent<Rigidbody2D> ();	
	}

	void Update () {
		anim.SetFloat ("speed", Mathf.Abs (rb2d.velocity.x));

		if (gameObject.GetComponent<AutoMoving>().Sin < 0) {
			gameObject.transform.GetChild (0).rotation = new Quaternion (0f, 0f, 0f, gameObject.transform.GetChild(0).rotation.w);
		} else if(gameObject.GetComponent<AutoMoving>().Sin > 0){
			gameObject.transform.GetChild (0).rotation = new Quaternion (0f, 180f, 0f, gameObject.transform.GetChild(0).rotation.w);
		}

	}
}
