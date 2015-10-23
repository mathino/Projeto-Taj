﻿using UnityEngine;
using System.Collections;

public class paiAnim : MonoBehaviour {

	private bool toAnimPai;

	// Use this for initialization
	void Start () {
		toAnimPai = false;
	}

	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("esse e:  " + toAnimPai);
		toAnimPai = (col.tag == "player");
	}

	void OnTriggerExit2D(Collider2D col){
		toAnimPai = !(col.tag == "player");
	}

	// Update is called once per frame
	void Update () {

		if (toAnimPai) {
			this.GetComponent<Animator> ().SetBool ("toAnimPai", true);
		} else {
			this.GetComponent<Animator> ().SetBool ("toAnimPai", false);
		}
	
	}
}