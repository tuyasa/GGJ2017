using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

	public int index	;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
        	if(other.tag == "Player") {
        		GameManager.Instance.scores[index] = true;
        		//Score the player
        		SoundManager.Instance.PlayCollectible();
			Destroy(this.gameObject);
        	}
    	}
}
