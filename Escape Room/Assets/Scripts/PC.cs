﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PC : MonoBehaviour {
	
	Canvas can;
	Text dialogue;
	Text adv;

	// Use this for initialization
	void Start () {
		can = GameObject.Find ("Canvas").GetComponent<Canvas> ();
		dialogue = GameObject.Find ("Dialogue").GetComponent<Text> ();
		adv = GameObject.Find ("Advance").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		
	void OnMouseDown(){
		SceneManager.LoadScene ("Screen");
	}

	private void OnTriggerEnter(Collider other)
	{
		dialogue.text = "Click computer to access.";
		adv.enabled = false;
		can.enabled = true;
	}



}
