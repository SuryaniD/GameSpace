using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Sprite h4;
	public Sprite h3;
	public Sprite h2;
	public Sprite h1;
	private Image sprite;
	[SerializeField]
	private Movement movement;

	// Use this for initialization
	void Start () {
		
		sprite = GetComponent<Image> ();
		if (sprite.sprite == null) {
			sprite.sprite = h4;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (movement.lives == 3) {
			sprite.sprite = h3;
		}
		if (movement.lives == 2) {
			sprite.sprite = h2;
		}
		if (movement.lives == 1) {
			sprite.sprite = h1;
		}
	}
}
