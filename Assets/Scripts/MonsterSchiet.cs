
using UnityEngine;
using System.Collections;

public class MonsterSchiet: MonoBehaviour {

	public GameObject projectile;
	public Vector2 velocity;
	bool canShoot = true;
    int richting = -1;
    public Vector2 offset = new Vector2(0.4f,0.1f);
	public float cooldown = 1f;

	public AudioSource Schietgeluid;



    // Use this for initialization
    void Start () {

    }

	// Update is called once per frame
	void Update () {

        if (canShoot) {

            Schietgeluid.Play();

            GameObject go = (GameObject)Instantiate(projectile, (Vector2)transform.position + offset * transform.localScale.x * richting, Quaternion.identity);

            go.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * transform.localScale.x * 2 * richting, velocity.y);

            StartCoroutine(CanShoot());

        }
        

	}


	IEnumerator CanShoot()
	{
		canShoot = false;
		yield return new WaitForSeconds (cooldown);
		canShoot = true;


	}
}