using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makechars : MonoBehaviour {
	/*public Char[] chars;
	public int charSize;
	public GameObject[] charPanels;
	public GUIText[] charText;
	// Use this for initialization
	void Start () {
		charSize = 0;
		charPanels[0] = GameObject.FindWithTag("char1");
		charPanels[1] = GameObject.FindWithTag("char2");
		charPanels[2] = GameObject.FindWithTag("char3");
		charPanels[3] = GameObject.FindWithTag("char4");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public class Char {
		
		public int hp;
		public string name;
		public int level;
		private string[] names = {"Bonehead", "Rimjob", "Bentface", "Buckfutter"};

		private string nameGen() {
			return names[Random.Range (0, 3)];
		}

		public Char() {
			name = nameGen();
			hp = 60;
			level = 1;
		}
	}

	public void addChar() {
		if (charSize < 4) {
			chars[charSize] = new Char ();
			charText = charPanels [chars.Length - 1].GetComponentsInChildren<GUIText>();
			charText [0] = chars[charSize].name;
			charText [1] = chars[charSize].hp;
			charText [2] = chars[charSize].level;
			charPanels [chars.Length - 1].SetActive ();
			charSize++;

		}
	}*/
}