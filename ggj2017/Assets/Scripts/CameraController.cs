using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {


	public Transform target;
	// Use this for initialization
	void Start () {
		if(target == null) {
			target = FindObjectOfType<WaveManager>().transform;
		}else  {
			Debug.LogError("You have to put a wavemanger TROLLOLOL");
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
	}
}
