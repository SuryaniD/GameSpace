using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	[SerializeField]
	public int health = 3;
	public GameObject pickup;

	private void Update(){
		if (health == 0) {
			Destroy (gameObject);
			GameObject _pickup = Instantiate (pickup, transform.position, Quaternion.identity);
		}
	}

}
