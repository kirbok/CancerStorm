﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerController : MonoBehaviour {
	float speed = 2.0f;
	Vector3 pos;
	Vector3 forward;
	Vector3 finalPos;
	Transform tr;

	// Use this for initialization
	void Start () {

		pos = transform.position;
		tr = transform;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space"))
		{
			forward = transform.forward;
			finalPos = forward;
			finalPos = Quaternion.Euler(0, 90, 0) * finalPos;
			float step = speed * Time.deltaTime;
			transform.position = Vector3.RotateTowards (forward, finalPos, step, 0.0f);
		}
		else if (Input.GetKey(KeyCode.A) && tr.position == pos)
		{
			pos += Vector3.left;
		}
		else if (Input.GetKey(KeyCode.W) && tr.position == pos)
		{
			pos += Vector3.forward;
		}
		else if (Input.GetKey(KeyCode.S) && tr.position == pos)
		{
			pos += Vector3.back;
		}

		//transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);
	}
}