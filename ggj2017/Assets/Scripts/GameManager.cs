using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : PersistentSingleton<GameManager> {

	public int level = 0;

	public int maxLevel = 7;

	public List<bool> scores = new List<bool>();
	// Use this for initialization
	void Start () {
		SoundManager.Instance.PlayGameBG();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Retry() {
		SceneManager.LoadScene("Level"+level);
	}

	public void CodeScene() {		
		SceneManager.LoadScene("Code"+level);
	}
	public void NextLevel() {
		scores.Clear();
		level++;
		if(level <= maxLevel) {
			SceneManager.LoadScene("Level"+level);	
		}else {
			SceneManager.LoadScene("Menu");
		}

	}
}
