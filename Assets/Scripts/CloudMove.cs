using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour{
	public Transform Player;

	void FixedUpdate(){
		transform.position = new Vector3 (Player.position.x / 3, Player.position.y / 3, transform.position.z / 3);
	}
}