using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testSound : MonoBehaviour {
    public AudioSource musique;
	// Use this for initialization
	void Start () {
        musique = GetComponent<AudioSource>();
        musique.clip = SoundManager.Instance.levelsSounds[0].background;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            musique.Play();
	}
}
