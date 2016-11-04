using UnityEngine;
using System.Collections;

public class speedup : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			var p = other.gameObject.GetComponent ("player") as player;
			p.speed += 1;
		}
		Destroy(gameObject);
	}
}
