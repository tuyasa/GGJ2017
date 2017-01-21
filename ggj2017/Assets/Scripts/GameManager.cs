using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PersistentSingleton<GameManager> {

	public int level = 0;

	public int maxLevel = 3;
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
			Debug.Log("ererr");
			SceneManager.LoadScene("Level"+level);	
		}else {
			Debug.Log("ererr");
			SceneManager.LoadScene("Menu");
		}

	}
}
