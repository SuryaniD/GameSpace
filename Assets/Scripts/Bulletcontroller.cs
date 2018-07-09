using System.Collections;
using UnityEngine;

public class Bulletcontroller : MonoBehaviour {

	public float speed;
	private Rigidbody2D _rb2d;
	// Use this for initialization
	void Start () {
		_rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		_rb2d.velocity = new Vector2 (speed, _rb2d.velocity.y);
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy (gameObject);
	}
}
