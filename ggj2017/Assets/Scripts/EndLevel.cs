using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

	void OnEnterTrigger2D(Collider2D other) {
		if(other.tag=="Player") {
			GameManager.Instance.NextLevel();
		}
	}
}
