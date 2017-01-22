using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {           
		StartCoroutine(PlaySoundAndDie());
        }

    }

    void OnCollisionEnter2D(Collision2D other) {
		StartCoroutine(PlaySoundAndDie());
    }



    	public void Retry() {
		GameManager.Instance.Retry();
    	}

    	IEnumerator PlaySoundAndDie() {    		
		SoundManager.Instance.PlayObstacle();
		Time.timeScale = 0f;
		yield return new WaitForSecondsRealtime(2f);
		Time.timeScale = 1f;
    		Retry();
    	}
}
