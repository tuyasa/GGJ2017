using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeManager : MonoBehaviour {

	
	[System.Serializable]
	public class Code {
		public int number;
		[SerializeField]
		public List<Image> images;
	}
	public List<Code> codes;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < codes.Count; i++) {
			if(GameManager.Instance.scores[i]) {
				foreach (var img in codes[i].images) {
					img.gameObject.SetActive(false);
				}
			}else {
				foreach (var img in codes[i].images) {
					img.gameObject.SetActive(true);
				}
			}
		}
		StartCoroutine(WaitToLaunch(10f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator WaitToLaunch(float time) {
		yield return new WaitForSeconds(time);
		GameManager.Instance.NextLevel();
	}
} 
