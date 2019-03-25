using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class KeyboardMovement : MonoBehaviour {

	[Header("Prędkość postaci")]
	public float speed = 10f;
	[Header("Siła skoku")]
	public float jumpForce = 50f;
	[Header("Maksymalna prędkość")]
	public float maxSpeed = 7f;

	private bool canJump;
	private bool canSpeedUp;
	private Rigidbody2D rb2d;
	private float horizontal;
	private float realSpeed;
	private GameOver gOver;


	public float Horizontal { 
		get{
			return horizontal;
		}
	}

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		realSpeed = speed;
		canJump = true;
		gOver = GameObject.Find ("GameOver").GetComponent<GameOver> ();
		canSpeedUp = true;

	}
	

	void Update () {
		if (gOver.playing) {
			horizontal = Input.GetAxis ("Horizontal");
		} else {
			horizontal = 0;
		}
			
		if (Mathf.Abs (rb2d.velocity.x) > maxSpeed) {
			canSpeedUp = false;

		}	else 
			canSpeedUp = true;

		if (rb2d.velocity.x * horizontal < 0) {
			realSpeed += Mathf.Abs (rb2d.velocity.x);
		} else
			realSpeed = speed;



		if ((Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow)) && canJump) {
			rb2d.AddForce (Vector2.up * jumpForce * 3);

			if (gameObject.tag == "Player")
				gameObject.GetComponent<Animator> ().SetTrigger ("jump");
			canJump = false;
		}

		if (rb2d.velocity.y != 0f && rb2d.gravityScale <= 3f) {

			rb2d.gravityScale += 0.07f;
		}
	}

    private void FixedUpdate()
    {
        if (canSpeedUp)
        {
            var oldVelocity = rb2d.velocity;
            rb2d.velocity =  new Vector2(1 * horizontal * realSpeed * Time.fixedDeltaTime, oldVelocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Ground") {
			canJump = true;
			rb2d.gravityScale = 1;
		}
		
	}
}
