using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public int currentLevel;
	public List<Collectible> collectibles;


	// Use this for initialization
	void Start () {
		for (int i = 0; i < collectibles.Count; i++) {
			collectibles[i].index = i;
			GameManager.Instance.scores.Add(false);
		}
		GameManager.Instance.level = currentLevel;
	}
	
	// Update is called once per frame
	void Update () {
				
	}	
}
