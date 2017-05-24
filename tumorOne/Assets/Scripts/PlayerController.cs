using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {
	float speed = 6.0f;
	Quaternion pos;
	Vector3 forward;
	Quaternion finalPos;
	Transform tr;
	//float angle;

	// Use this for initialization
	void Start () {

		pos = transform.rotation;
		tr = transform;
		finalPos = pos;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("d"))
		{
			finalPos = Quaternion.Euler(new Vector3(pos.eulerAngles.x, pos.eulerAngles.y + 90, pos.eulerAngles.z));
		}
		else if (Input.GetKeyDown("a"))
		{
			finalPos = Quaternion.Euler(new Vector3(pos.eulerAngles.x, pos.eulerAngles.y - 90, pos.eulerAngles.z));
		}
//		else if (Input.GetKey(KeyCode.W) && tr.position == pos)
//		{
//			pos += Vector3.forward;
//		}
//		else if (Input.GetKey(KeyCode.S) && tr.position == pos)
//		{
//			pos += Vector3.back;
//		}
//
//		//transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}

	void FixedUpdate() {
		transform.rotation = Quaternion.Slerp(transform.rotation, finalPos, Time.deltaTime * speed);
		/*if ((finalPos.eulerAngles.y - transform.rotation.eulerAngles.y) < 1 &&  (finalPos.eulerAngles.y - transform.rotation.eulerAngles.y) > -1) {
			transform.rotation = finalPos;
		}*/
	}
}