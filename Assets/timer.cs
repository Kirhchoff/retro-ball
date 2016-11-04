using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	public float interval;
	public GameObject [] powerups;
	private float remaining;
	GameObject spawned;

	void Start () {
		remaining = interval;
	}

	void Update () {
		remaining -= spawned ? 0 : Time.deltaTime;
		if (remaining <= 0) {
			spawn ();
			remaining = interval;
		}
	}

	void spawn() {
		if (!spawned) {
			Vector3 position = new Vector3 (Random.Range (-8.95f, 19.0f), Random.Range (-4.3f, 9.0f), 0);
			spawned = (GameObject)Instantiate (powerups[Random.Range(0, powerups.Length)], position, Quaternion.identity);
		}
	}
}
