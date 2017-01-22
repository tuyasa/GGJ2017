using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour {


	public float speedX;
	public float speedY;

	public GameObject wavePrefab;
	public List<WaveController> waves;


	public Vector2 currentPoint;
	// Use this for initialization
	void Start () {
		currentPoint = Vector2.zero;
		CreateWaveLine(transform.position);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentPoint.x += speedX * Time.deltaTime;
		transform.position = new Vector3(currentPoint.x, transform.position.y, transform.position.z);
	}

	public void CreateWaveLine(Vector3 position, int direction = 0) {
		GameObject go = Instantiate(wavePrefab, position, Quaternion.identity) as GameObject;
		WaveController wave = go.GetComponent<WaveController>();
		wave.directionY = direction;
		waves.Add(wave);
	}

	public void DiscardWaves() {
		foreach(WaveController wave in waves) {
			Destroy(wave.gameObject);
		}
		waves.Clear();
	}

}
