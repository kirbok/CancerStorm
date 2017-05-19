using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class testMovement : MonoBehaviour {
	float speed = 2.0f;
	Vector3 pos;
	Transform tr;

	// Use this for initialization
	void Start () {

		pos = transform.position;
		tr = transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.D) && tr.position == pos)
		{
			pos += Vector3.right;
		}
		else if (Input.GetKey(KeyCode.A) && tr.position == pos)
		{
			pos += Vector3.left;
		}
		else if (Input.GetKey(KeyCode.W) && tr.position == pos)
		{
			pos += Vector3.up;
		}
		else if (Input.GetKey(KeyCode.S) && tr.position == pos)
		{
			pos += Vector3.down;
		}

		transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}
}
