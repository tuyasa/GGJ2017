﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
        	if(other.tag == "Player") {
        		Debug.LogError("border" + this.gameObject.name);
        		Invoke("Retry", 2f);		
        	}
		
    	}
    	public void Retry() {
		GameManager.Instance.Retry();
    	}
}