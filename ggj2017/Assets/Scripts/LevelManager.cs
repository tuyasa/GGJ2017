using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public int currentLevel;
	public List<Collectible> collectibles;
	public static int score;
	// Use this for initialization
	void Start () {
		GameManager.Instance.level = currentLevel;
	}
	
	// Update is called once per frame
	void Update () {
		
	}	
}
