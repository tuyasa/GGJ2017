using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : PersistentSingleton<SoundManager> {
	public new AudioSource audio;

	[System.Serializable]
	public class LevelSounds {
		public AudioClip collectible;
		public AudioClip start;
        public AudioClip end;
        public AudioClip background;

    }

	public List<LevelSounds> levelsSounds;

    public void PlaySingle(AudioClip clip )
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
    }

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
