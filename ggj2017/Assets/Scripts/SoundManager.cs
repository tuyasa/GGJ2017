using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : PersistentSingleton<SoundManager> {

    public static SoundManager instance = null;
	public AudioSource audio;

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

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
