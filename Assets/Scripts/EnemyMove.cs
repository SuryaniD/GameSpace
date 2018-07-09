using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	public float amplitude;          //Set in Inspector 
	public float speed;                  //Set in Inspector 
	public float tempVal;
	public Vector3 tempPos;

	void Start () 
	{
		tempVal = transform.position.x;
	}

	void Update ()
	{        
		tempPos.x = tempVal + amplitude * Mathf.Sin (speed * Time.time);
		transform.position = tempPos;

	}
}