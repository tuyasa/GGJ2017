using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour {

	public float margin;
	[System.Serializable]
	public class Dot {
		public Vector2 point;
		public bool check;
	}
	public List<Dot> pattern;
	public List<Vector2> trace;

	public WaveController waveController;
	// Use this for initialization
	void Start () {
		waveController = FindObjectOfType<WaveController>();
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var item in pattern) {
			if((item.point.x + transform.position.x) <= waveController.transform.position.x && !item.check) {
				AddPoint(new Vector2(item.point.x, waveController.transform.position.y));
				item.check = true;
			}
		}
	}
	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		foreach (var item in pattern) {
			Gizmos.DrawCube(item.point + (Vector2)transform.position, Vector3.one*2);	
		}
		Gizmos.color = Color.blue;
		foreach (var item in trace) {
			Gizmos.DrawCube(item +(Vector2) transform.position, Vector3.one*2);	
		}
	}

	public void ClearPoints() {
		trace.Clear();
	}

	public void AddPoint(Vector2 position) {
		trace.Add(position);
	}


	public float EvaluatePattern() {
		List<Vector2> patternPoints = new List<Vector2>();
		float sum = 0f;
		foreach (var item in pattern) {
			patternPoints.Add(item.point+(Vector2)transform.position);
		}
		for (int i = 0; i < patternPoints.Count; i++) {
			sum+= Mathf.Abs(patternPoints[i].y - trace[i].y);
		}

		return sum;
	}

	void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Player") {
			Debug.Log(EvaluatePattern());
			if(EvaluatePattern() > margin)
				GameManager.Instance.Retry();
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") {
			SoundManager.Instance.PlayObstacle();
			trace.Clear();
		}
	}
}
