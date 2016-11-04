using UnityEngine;
using System.Collections;

public class burger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("Player")) {
			other.transform.localScale += new Vector3 (0.5F, 0.5F, 0.5F);
		}
		Destroy(gameObject);
	}
}
