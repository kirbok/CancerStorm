using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {
	private GameObject info;
	// Use this for initialization
	//private GameObject clearPanel;
	int clear = 500;
	void Start () {
		
	}
	

	public void button (int infoDisplay) {

		//this.gameObject.transform.GetChild (clear);
		info = this.gameObject.transform.GetChild(infoDisplay).gameObject;
		//clearPanel = this.gameObject.transform.GetChild(clear).gameObject;
		//clearPanel.SetActive (false);

		info.SetActive (true);

		clear = infoDisplay;
		
	}
}
