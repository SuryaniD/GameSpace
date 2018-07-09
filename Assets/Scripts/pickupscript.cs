using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupscript : MonoBehaviour {

	public int pickup = 0;
	public AudioSource pickUpGeluid;
    public Text ScoreTekst;
	public GameObject Portal;

    // Use this for initialization
    void Start () {

    }

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "pick") {
			pickUpGeluid.Play ();
			Destroy (col.gameObject);
			Score.pickups++;
			ScoreTekst.text = "Door Keys: " + Score.pickups + "/4";
			if (Score.pickups >= 4) {
				ScoreTekst.text += " Door is open";
				GameObject _Portal = (GameObject)Instantiate (Portal, new Vector3 (10, 1.5f, 0), Quaternion.identity);
				print ("DOOR SPAWNED");
			}
		}
	}
}
