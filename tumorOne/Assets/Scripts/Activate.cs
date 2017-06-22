using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
	private bool showing = false;

	private GameObject Menu;
	void Start ()
	{
		Menu = this.gameObject.transform.GetChild(0).gameObject;
		Menu.SetActive (false);
	}

	// Use this for initialization
	void Update()
	{

		if (Input.GetKeyDown("escape"))
		{
			if (showing == false) {
				Menu.SetActive (true);
				showing = true;
			}
			else if (showing == true) {
				Menu.SetActive (false);
				showing = false;
			}
		}
	}

}
