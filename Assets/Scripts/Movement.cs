using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	float dirX, dirY;
	public float moveSpeed = 10f;
	Rigidbody2D rb;
    Animator animator;
    public float jumpSpeed = 900000f;
	public bool canJump = false;
	public int lives = 4;
	bool invincible = false;
	public float spriteBlinkingTimer = 0.0f;
	public float spriteBlinkingMiniDuration = 0.1f;
	public float spriteBlinkingTotalTimer = 0.0f;
	public float spriteBlinkingTotalDuration = 1.0f;
	public bool startBlinking = false;
	public AudioSource HitGeluid;
	public GameObject bullet;
    public GameObject SceneManager;

    
    void Start(){
		rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D col){
		Debug.Log ("OnTriggerEnter()");
		if (col.gameObject.tag == "Ground")
			canJump = true;
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (!invincible) {
			if (coll.gameObject.tag == "Enemy") {
				HitGeluid.Play();
				Debug.Log ("Hit");
				lives -= 1;
				invincible = true;
				Invoke ("resetInvulnerability", 3);
				startBlinking = true;

			}
		}
	}

	void resetInvulnerability(){
		invincible = false;
	}

	private void SpriteBlinkingEffect()
	{
		spriteBlinkingTotalTimer += Time.deltaTime;
		if(spriteBlinkingTotalTimer >= spriteBlinkingTotalDuration)
		{
			startBlinking = false;
			spriteBlinkingTotalTimer = 0.0f;
			this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;  
			//your sprite
			return;
		}

		spriteBlinkingTimer += Time.deltaTime;
		if(spriteBlinkingTimer >= spriteBlinkingMiniDuration)
		{
			spriteBlinkingTimer = 0.0f;
			if (this.gameObject.GetComponent<SpriteRenderer> ().enabled == true) {
				this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;
			} else {
				this.gameObject.GetComponent<SpriteRenderer> ().enabled = true;
			}
		}
	}

	private void Death(){
		if (lives <= 0) {
            Application.LoadLevel("DeathScreen");
        }
	}

	void Update(){
		dirX = Input.GetAxis ("Horizontal");

        if (dirX != 0) {
            animator.SetBool("Lopend", true);
        } else {
            animator.SetBool("Lopend", false);
        }

        Death ();
		if(startBlinking == true)
		{ 
			SpriteBlinkingEffect();
		}
		}

	void FixedUpdate(){
		rb.velocity = new Vector2 (dirX * moveSpeed, rb.velocity.y);
		if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
		{
			Debug.Log ("jump");
			rb.velocity = new Vector2 (rb.velocity.x, 1 * jumpSpeed * Time.fixedDeltaTime);
			canJump = false;
		}
		if (Input.GetButton("Fire1") && canJump == true)
		{
			Debug.Log ("jump");
			rb.velocity = new Vector2 (rb.velocity.x, 1 * jumpSpeed * Time.fixedDeltaTime);
			canJump = false;
		}


	}

		
}