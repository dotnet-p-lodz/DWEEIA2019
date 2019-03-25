using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollowingObject : MonoBehaviour {

	public GameObject objectToFollow;

	private Vector3 offset;
	private bool changingBoth;

	void Start () {
		changingBoth = false;
	}
	

	void Update () {
		offset = objectToFollow.transform.position - transform.position;

		if (offset.x > 4f && offset.y > 2f) {
			Vector3 offsetWhenChange = new Vector3 (4f, 2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
			changingBoth = true;
		}

		if (offset.x > 4f && offset.y < -2f) {
			Vector3 offsetWhenChange = new Vector3 (4f, -2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
			changingBoth = true;
		}

		if (offset.x < -4f && offset.y > 2f) {
			Vector3 offsetWhenChange = new Vector3 (-4f, 2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
			changingBoth = true;
		}

		if (offset.x < -4f && offset.y < -2f) {
			Vector3 offsetWhenChange = new Vector3 (-4f, -2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
			changingBoth = true;
		}




		if (offset.x > 4f && !changingBoth) {
			Vector3 offsetWhenChange = new Vector3 (4f, offset.y, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
		}

		if (offset.x < -4f && !changingBoth) {
			Vector3 offsetWhenChange = new Vector3 (-4f, offset.y, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
		}

		if (offset.y > 2f && !changingBoth) {
			Vector3 offsetWhenChange = new Vector3 (offset.x, 2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
		}

		if (offset.y < -2f && !changingBoth) {
			Vector3 offsetWhenChange = new Vector3 (offset.x, -2f, offset.z);
			transform.position = objectToFollow.transform.position - offsetWhenChange;
		}

		changingBoth = false;
	}
		
}
