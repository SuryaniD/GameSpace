
using UnityEngine;
using System.Collections;

public class Schiet: MonoBehaviour {

	public GameObject projectile;
	public Vector2 velocity;
	bool canShoot = true;
    int richting = 1;
    public Vector2 offset = new Vector2(0.4f,0.1f);
	public float cooldown = 1f;
    Rigidbody2D man;
	public AudioSource Schietgeluid;

	private SpriteFlipper spriteFlipper;

    // Use this for initialization
    void Start () {
        man = GetComponent<Rigidbody2D>();
		spriteFlipper = GetComponent<SpriteFlipper> ();
    }

	// Update is called once per frame
	void Update () {

		richting = spriteFlipper.GetFlip () ? -1 : 1;

		/*
		if (spriteFlipper.GetFlip () == true)
			richting = -1;
		else
			richting = 1;
*/
		/*
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
        {
            richting = 1;
        }

        if (GetComponent<Rigidbody2D>().velocity.x < 0)
        {
            richting = -1;
        }
		*/
		if (Input.GetButtonDown("Fire2") && canShoot) {

			Schietgeluid.Play();

            GameObject go = (GameObject)	Instantiate (projectile,(Vector2)transform.position + offset * transform.localScale.x * richting, Quaternion.identity);

			go.GetComponent<Rigidbody2D> ().velocity = new Vector2 (velocity.x * transform.localScale.x * 2 * richting, velocity.y);

			StartCoroutine (CanShoot());

		}
        

	}


	IEnumerator CanShoot()
	{
		canShoot = false;
		yield return new WaitForSeconds (cooldown);
		canShoot = true;


	}
}