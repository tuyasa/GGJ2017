using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {
	public float speedX = 3f;
	public float speedY = 3f;
	 
	LineRenderer line;
	public Vector2 currentPoint;

	public int directionY;
	// Use this for initialization
	void Start () {
		currentPoint = transform.position;	
	}	

	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)) {
			directionY = directionY == 1 ? -1 : 1;		
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentPoint.x += speedX * Time.deltaTime;
		currentPoint.y += speedY * directionY * Time.deltaTime;
		transform.position = new Vector3(currentPoint.x, currentPoint.y, transform.position.z);
	}
}
