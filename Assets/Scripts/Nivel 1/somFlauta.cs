﻿using UnityEngine;
using System.Collections;

public class somFlauta : MonoBehaviour {

	private ShowButton sB;
	public GameObject aS;
	private PlayerClimb pc;
	public GameObject aC;

	// Use this for initialization
	void Start () {
		pc = GameObject.Find ("player").GetComponent<PlayerClimb> ();
		sB = this.gameObject.GetComponent ("ShowButton") as ShowButton;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (aC.gameObject.activeSelf == true && pc.flauta == true) {
			aS.audio.enabled = true;
		} 
	}
}