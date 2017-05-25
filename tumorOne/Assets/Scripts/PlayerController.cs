using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {
	float rotSpeed = 6.0f;
	float moveSpeed = 6.0f;
	Quaternion rot, finalRot;
	Vector3 finalPos, pos;
	Transform tr;
	int counter = 0;
	//float angle;

	// Use this for initialization
	void Start () {

		rot = transform.rotation;
		pos = transform.position;
		tr = transform;
		finalRot = rot;
		finalPos = pos;
	}

	Vector3 MoveForward() {
		Vector3 v3 = Vector3.zero;
		if (Mathf.Approximately(rot.eulerAngles.y,90.0f)) {
			v3 = new Vector3 (tr.position.x,tr.position.y ,tr.position.z - 10);
		} else if (Mathf.Approximately(rot.eulerAngles.y,-90.0f)) {
			v3 = new Vector3 (tr.position.x,tr.position.y ,tr.position.z + 10);
		} else if (Mathf.Approximately(rot.eulerAngles.y,0.0f)) {
			v3 = new Vector3 (tr.position.x - 10,tr.position.y ,tr.position.z);
		} else if (Mathf.Approximately(rot.eulerAngles.y,180.0f)) {
			v3 = new Vector3 (tr.position.x + 10,tr.position.y ,tr.position.z);
		}
		return v3;
	}

	Vector3 MoveBackward() {
		Vector3 v3 = Vector3.zero;
		if (rot.eulerAngles.y == 90) {
			v3 = new Vector3 (tr.position.x,tr.position.y ,tr.position.z + 10);
		} else if (rot.eulerAngles.y == 270) {
			v3 = new Vector3 (tr.position.x,tr.position.y ,tr.position.z - 10);
		} else if (rot.eulerAngles.y == 0) {
			v3 = new Vector3 (tr.position.x + 10,tr.position.y ,tr.position.z);
		} else if (rot.eulerAngles.y == 180) {
			v3 = new Vector3 (tr.position.x - 10,tr.position.y ,tr.position.z);
		}
		return v3;
	}

	// Update is called once per frame
	void Update () {
		if (counter == 0) {
			if (Input.GetAxis ("Horizontal") > 0) {
				finalRot = Quaternion.Euler (new Vector3 (rot.eulerAngles.x, rot.eulerAngles.y + 90, rot.eulerAngles.z));
				//finalPos = Quaternion.LookRotation(new Vector3(pos.eulerAngles.x, pos.eulerAngles.z, pos.eulerAngles.y + 90));
				counter = 20;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				finalRot = Quaternion.Euler (new Vector3 (rot.eulerAngles.x, rot.eulerAngles.y - 90, rot.eulerAngles.z));
				//finalPos = Quaternion.LookRotation(new Vector3(pos.eulerAngles.x, pos.eulerAngles.z, pos.eulerAngles.y - 90));
				counter = 20;
			} else if (Input.GetAxis ("Vertical") > 0) {
				finalPos = MoveForward ();
				counter = 20;
			} else if (Input.GetAxis ("Vertical") < 0) {
				finalPos = MoveBackward ();
				counter = 20;
			}
		} else {
			counter--;
		}
		//tr.rotation = Quaternion.Slerp(tr.rotation, finalPos, Time.deltaTime * speed);
//		//transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}

	void FixedUpdate() {
		transform.position = Vector3.MoveTowards (pos, finalPos, Time.deltaTime * moveSpeed);
		tr.rotation = Quaternion.Slerp(tr.rotation, finalRot, Time.deltaTime * rotSpeed);
		/*if ((finalPos.eulerAngles.y - transform.rotation.eulerAngles.y) < 1 &&  (finalPos.eulerAngles.y - transform.rotation.eulerAngles.y) > -1) {
			transform.rotation = finalPos;
		}*/
	}
}