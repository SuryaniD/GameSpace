using UnityEngine;
using System.Collections;

public class CamMove : MonoBehaviour{
	public Transform Player;

	void FixedUpdate(){
		transform.position = new Vector3 (Player.position.x, Player.position.y, transform.position.z);
	}
}