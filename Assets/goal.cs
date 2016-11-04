using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class goal : MonoBehaviour {

	public Text scoreText;
	private int score;

	void Start () {
		scoreText.text = "0";
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag ("ball")) {
			score += 1;
			scoreText.text = score.ToString();
		}
	}
}
