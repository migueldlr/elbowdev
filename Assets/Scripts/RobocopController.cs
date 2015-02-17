using UnityEngine;
using System.Collections;

public class RobocopController : MonoBehaviour {
	public float maxSpeed = 7.5f;
	bool facingRight = true;
	
	Animator anim;

	public GameObject player;
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 300f;
	bool doubleJump;
	Vector2 start;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");

		
		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);
		
		if (move > 0 && !facingRight) {
			Flip ();
		} else if (move < 0 && facingRight) {
			Flip();		
		}
	}

	void Flip(){
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
