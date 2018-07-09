using UnityEngine;
using System.Collections;

public class CityMove : MonoBehaviour{
	public Transform Player;

	void FixedUpdate(){
		transform.position = new Vector3 (Player.position.x/1.2f , Player.position.y, transform.position.z);
	}
}