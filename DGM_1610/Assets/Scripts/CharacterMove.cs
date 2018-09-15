using UnityEngine;
using System.Collections; //dont delete these lol but you already knew that

public class CharacterMove : MonoBehaviour {

	// player movement variables
	public int MoveSpeed;
	public float JumpHeight;

	// player grounded variables
    //access modifiers, 
	public Transform GroundCheck; //position, rotation and scale of obj.
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	// Use this for initialization
	void Start ()
    {
	
	}
	

	void FixedUpdate ()
    {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update ()
    {
		// this makes the your character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded)
        {
			Jump();
		}
		// this moves character side to side with A and D ;)
		if(Input.GetKey (KeyCode.D))
        {
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);	
		}
		if(Input.GetKey (KeyCode.A))
        {
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}

	}

	public void Jump()
    {
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
