using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private CharacterController cc;
	private bool movingfor, movingrev, rotting;
	private int counter;
	private float posx, posz;
	private Rigidbody collider;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController>();
		//rb = GetComponent<>();
		movingfor = false;
		movingrev = false;
		counter = 0;
		rotting = false;

		collider = GetComponent<Collider> ().attachedRigidbody;

	}
	
	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		if (moveVertical > 0) { //move forward
			movingfor = true;
			posx = collider.position.x;
			posz = collider.position.z;
		} else if (moveVertical < 0) { //move backward
			movingrev = true;
			posx = collider.position.x;
			posz = collider.position.z;
		}
		Vector3 forward = transform.TransformDirection(Vector3.forward);

		cc.SimpleMove (forward * 3);
	}
	/*
	void FixedUpdate () {
		if (movingfor) {
			transform.Translate (new Vector3 (0, 0, 20) * Time.deltaTime, Space.Self);
			movingfor = false;

		} else if (movingrev) {
			transform.Translate (new Vector3 (0, 0, -20) * Time.deltaTime, Space.Self);
			movingrev = false;

		} else if (rotting) {
			if (counter > 1) {
				counter--;
			} else {
				rotting = false;
				counter--;
			}
		} else {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			if (moveVertical > 0) { //move forward
				movingfor = true;
				posx = rb.position.x;
				posz = rb.position.z;
			} else if (moveVertical < 0) { //move backward
				movingrev = true;
				posx = rb.position.x;
				posz = rb.position.z;
			}

			if (!movingfor && !movingrev) {
				if (moveHorizontal < 0) { //turn left
					rotting = true;
					counter = 20;
					transform.Rotate(0, -90, 0);
				} else if (moveHorizontal > 0) { //turn right
					rotting = true;
					counter = 20;
					transform.Rotate(0, 90, 0);
				}
			}

				
		}

	}*/
}
