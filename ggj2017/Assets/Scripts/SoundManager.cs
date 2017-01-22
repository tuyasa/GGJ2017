using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundManager : PersistentSingleton<SoundManager>
{

	public AudioSource audio;
	public AudioClip collectible;
	public AudioClip gameBackground;
	public AudioClip menuBackground;
	public List<AudioClip> obstacles;
	public List<AudioClip> interfaces;

	public GameObject tempAudio;

	// Use this for initialization
	void Awake ()
	{
		base.Awake ();
		audio = GetComponent<AudioSource> ();
	}

	private void PlaySingle (AudioClip clip)
	{
		audio.Stop ();
		audio.clip = clip;
		audio.Play ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void PlayInterfaces ()
	{		
		PlayTemporarySound (interfaces [Random.Range (0, interfaces.Count)]);
	}

	public void PlayObstacle ()
	{
		
		PlayTemporarySound (obstacles [Random.Range (0, obstacles.Count)]);
	}

	public void PlayGameBG ()
	{
		PlaySingle (gameBackground);
	}

	public void PlayerMenuBG ()
	{
		PlaySingle (menuBackground);
	}

	public void PlayCollectible ()
	{
		PlayTemporarySound (collectible);
//		GameObject go = (GameObject)Instantiate (tempAudio, transform.position, Quaternion.identity);
//		AudioSource au = go.GetComponent<AudioSource>();
//		au.clip = collectible;
//		au.Play();
//		StartCoroutine(BgSound(collectible.length));
//		Destroy (go, collectible.length);
	}

	public void PlayTemporarySound (AudioClip clip)
	{
		GameObject go = (GameObject)Instantiate (tempAudio, transform.position, Quaternion.identity);
		AudioSource au = go.GetComponent<AudioSource> ();
		au.clip = clip;
		au.volume = 0.5f;
		au.Play ();
		StartCoroutine (BgSound (collectible.length));
		Destroy (go, collectible.length);
	}


	public void LowerBackground ()
	{
		audio.volume = 0.2f;
	}

	public void HigherBackground ()
	{
		audio.volume = 0.7f;
	}

	IEnumerator BgSound (float time)
	{
		LowerBackground ();
		yield return new WaitForSeconds (time);
		HigherBackground ();
	}
}
