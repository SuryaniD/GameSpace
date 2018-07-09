using System.Collections;
using UnityEngine;

public class Kogel : MonoBehaviour {

	void Start () {
		Destroy (gameObject, 0.3f); //Verwijder kogel na 5 seconden
	}

	void OnTriggerEnter2D(Collider2D other) //Als de kogel iets raakt
	{
		Destroy (gameObject); //Verwijder kogel

		if (other.gameObject.tag == "Enemy") {
			other.GetComponent<Enemy> ().health--;
		}
		if (other.gameObject.tag == "Ground") {
			Destroy (gameObject);
		}
	}
}
