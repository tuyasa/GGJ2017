using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	
	public float speedX = 3f;
	public float speedY = 3f;
	 
	LineRenderer line;
	int pos;
	public Vector2 currentPoint;

	public int directionY;
	// Use this for initialization
	void Start () {
//		directionY = 1;
		currentPoint = Vector2.zero;
		pos = 1;
		line = GetComponent<LineRenderer>()	;
	}	
	
	// Update is called once per frame
	void Update () {
		Debug.Log("dirY"+directionY);
		currentPoint.x += speedX;
		currentPoint.y += speedY * directionY;
		if(Input.GetKeyDown(KeyCode.Space)) {
			directionY = directionY == 1 ? -1 : 1;
			line.numPositions++;
			pos++;
			line.SetPosition(pos, currentPoint);
		}
		line.SetPosition(pos, currentPoint);
	}
}
