﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)) {
			
			LaunchGame();
		}
	}

	public void LaunchMenu () {
		SceneManager.LoadScene("Menu");
	}

	public void LaunchGame() {
		SceneManager.LoadScene("Level1");
	}
}
