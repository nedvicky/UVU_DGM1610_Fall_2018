using UnityEngine;
using System.Collections; //dont delete these lol but you already knew that

public class CharacterMove : MonoBehaviour {

	// player movement variables
	public int MoveSpeed;
	public float JumpHeight;
    private bool DoubleJump;

	// player grounded variables
    //access modifiers, (GUI layouts), defining the variable, variable;
	public Transform GroundCheck; //position, rotation and scale of obj.
	public float GroundCheckRadius;
	public LayerMask WhatIsGround; //allow you to display the LayerMask popup menu in the inspector
    private bool Grounded;

    //non-stick player
    private float MoveVelocity;

	// Use this for initialization
	void Start () //void means no data is returned (no repeat) also it is a type not a function (argument) 
    {
	
	}
	

	void FixedUpdate () //this can be used to validate different types of arguments
    {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update ()
    {
		// this makes the your character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded) //event
        {
			Jump();
		}
        //double jump here
        if (Grounded)
            DoubleJump = false;
        if(Input.GetKeyDown (KeyCode.Space)&& !DoubleJump && !Grounded) //! means false - && logical operator
        {
            Jump();
            DoubleJump = true; //to make sure the player doesnt jump again
        }
        //non-stick player
        MoveVelocity = 0f;

		// this will moves character side to side with A and D ;)
		if(Input.GetKey (KeyCode.D))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);	
            MoveVelocity = MoveSpeed;
		}
		if(Input.GetKey (KeyCode.A))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            MoveVelocity = -MoveSpeed;
		}

        //player flip
        if (GetComponent<Rigidbody2D>().velocity.x > 0)
            transform.localScale = new Vector3(400f, 400f, 1f);

        else if (GetComponent<Rigidbody2D>().velocity.x < 0)
            transform.localScale = new Vector3(-400f, 400f, 1f);

        GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVelocity, GetComponent<Rigidbody2D>().velocity.y);

    }

	public void Jump()
    {
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
