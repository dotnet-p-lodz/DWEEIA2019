using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIGroundCheck : MonoBehaviour {

	private bool left;
	public bool onGround;

	void Awake(){
		onGround = false;
		if (gameObject.name.Substring (gameObject.name.Length - 1) == "L") {
			left = true;
		} else {
			left = false;
		}
	}

    void OnTriggerExit2D(Collider2D other)
    {
		if(other.gameObject.tag == "Ground" && onGround)
        {
			if (left)
				gameObject.transform.parent.gameObject.GetComponent<AutoMoving> ().canGoL = false;
			else
				gameObject.transform.parent.gameObject.GetComponent<AutoMoving> ().canGoR = false;
        }
    }

	void OnTriggerStay2D(Collider2D other)
	{
		Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "Tilemap" || other.gameObject.name == "Meta")
		{
			if (left)
				gameObject.transform.parent.gameObject.GetComponent<AutoMoving> ().canGoL = true;
			else
				gameObject.transform.parent.gameObject.GetComponent<AutoMoving> ().canGoR = true;
		}
	}


}
