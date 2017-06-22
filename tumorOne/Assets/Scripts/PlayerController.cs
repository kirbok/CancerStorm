using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {
	public float rotSpeed = 6.0f;
	public float moveSpeed = 6.0f;
	public float walkSpeed = 16.0f;
	Quaternion rot;
	Vector3 finalPos, pos;
	Vector3 testRot;
	Transform tr;
	int counter = 0;
	//float angle;

	// Use this for initialization
	void Start () {

		rot = transform.rotation;
		pos = transform.position;
		tr = transform;

	}
		

	// Update is called once per frame
	void Update () {
		if (counter == 0) {
			if (Input.GetAxis ("Horizontal") > 0) {
				//gets vector pointing 90 degrees from forward
				testRot = Quaternion.Euler(0, 90, 0) * transform.forward;

				counter = 30;
			} else if (Input.GetAxis ("Horizontal") < 0) {
				//gets vector pointing -90 degrees from forward
				testRot = Quaternion.Euler(0, -90, 0) * transform.forward;

				counter = 30;
			} else if (Input.GetAxis ("Vertical") > 0) {
				
				pos += transform.forward * 10;
				counter = 30;
			} else if (Input.GetAxis ("Vertical") < 0) {
				pos += -transform.forward * 10;
				counter = 30;
			}
		} else {
			counter--;
		}

	}

	void FixedUpdate() {
		transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * walkSpeed);
		Vector3 newDir = Vector3.RotateTowards (transform.forward, testRot, moveSpeed * Time.deltaTime, 1);
		transform.rotation = Quaternion.LookRotation (newDir);
	}
}