using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour {

	WaveManager waveManager;
	// Use this for initialization
	void Start () {
		waveManager = FindObjectOfType<WaveManager>();
		if(waveManager != null) 
			Debug.LogError("Not any wavemanager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {		
		if(other.tag=="Player") {
			GetComponent<BoxCollider2D>().isTrigger = false;
			Destroy(other.transform.parent.gameObject);
			waveManager.CreateWaveLine(transform.position, -1);
			waveManager.CreateWaveLine(transform.position, 1);
		}
	}

}
