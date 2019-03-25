using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoving : MonoBehaviour {

    public bool canGoL;
	public bool canGoR;
    public float speed = 10f;

    private GameOver gOver;
    private Rigidbody2D rb2d;
	private float sin;

	public float Sin{
		get{
			return sin;
		}
	}

	void Start () {
        canGoL = true;
		canGoR = true;
        gOver = GameObject.Find("GameOver").GetComponent<GameOver>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();


		gameObject.transform.GetChild (1).gameObject.GetComponent<AIGroundCheck> ().onGround = false;
		gameObject.transform.GetChild (2).gameObject.GetComponent<AIGroundCheck> ().onGround = false;
    }


    void FixedUpdate()
    {
		if(gOver.playing && Mathf.Abs(rb2d.velocity.x) < 7f)
        {
			sin = Mathf.Sin (Time.time * 1.5f);
			if (sin <= 0 && canGoL) {
				rb2d.velocity = (Vector2.right * speed * sin);
			} else if (!canGoL) {
				Stop ();
			}

			if (sin > 0 && canGoR) {
				rb2d.velocity = (Vector2.right * speed * sin);
			} else if (!canGoR) {
				Stop ();
			}


        }
    }


	void Stop(){
		rb2d.AddForce (rb2d.velocity * -10f);
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			gameObject.transform.GetChild (1).gameObject.GetComponent<AIGroundCheck> ().onGround = true;
			gameObject.transform.GetChild (2).gameObject.GetComponent<AIGroundCheck> ().onGround = true;
		}
	}

}
