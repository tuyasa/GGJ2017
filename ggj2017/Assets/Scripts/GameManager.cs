using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PersistentSingleton<GameManager> {

	public int level = 0;

	public int maxLevel = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Retry() {
		SceneManager.LoadScene("Level"+level);
	}

	public void NextLevel() {
		level++;
		if(level <= maxLevel) {
			SceneManager.LoadScene("Level"+level);	
		}else {
			SceneManager.LoadScene("Menu");
		}

	}
}
