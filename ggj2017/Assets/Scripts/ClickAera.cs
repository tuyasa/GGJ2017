using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickAera : MonoBehaviour
{

	public float displayTime;
	public Text number;
	public int clickToAchieve;
	int click;
	// Use this for initialization
	void Start ()
	{
		number = FindObjectOfType<Text>();
		if(number != null) {
			number.text = clickToAchieve.ToString();
		}
		number.gameObject.SetActive(false);
		click = 0;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Space)) {
			click++;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{		
		click = 0;
		if (other.tag == "Player") {
			// print UI	
			StartCoroutine(DisplayText());
			SoundManager.Instance.PlayInterfaces();
		}
	}

	void OnTriggerExit2D (Collider2D other)
	{
		if (other.tag == "Player") {
			
			if (click >= clickToAchieve) {
				
			}else {
				GameManager.Instance.Retry();
			}
		}
	}

	IEnumerator DisplayText() {
		number.gameObject.SetActive(true);
		yield return new WaitForSeconds(displayTime);
		number.gameObject.SetActive(false);
	}
}
