using System.Collections;
using UnityEngine;

public class KogelEnemy : MonoBehaviour {

	void Start () {
		Destroy (gameObject, 1f); //Verwijder kogel na 5 seconden
	}

	void OnTriggerEnter2D(Collider2D other) //Als de kogel iets raakt
	{
		Destroy (gameObject); //Verwijder kogel

		if (other.gameObject.tag == "Player") {
			other.GetComponent<Movement> ().lives--;
        }
		if (other.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}
