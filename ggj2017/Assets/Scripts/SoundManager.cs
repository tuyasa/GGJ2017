using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : PersistentSingleton<SoundManager> {


	public AudioSource audio;
	[System.Serializable]
	public class LevelSounds {
		public AudioClip bg;
		public AudioClip win;
		public AudioClip lose;
	}

	public List<LevelSounds> levelsSounds;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
