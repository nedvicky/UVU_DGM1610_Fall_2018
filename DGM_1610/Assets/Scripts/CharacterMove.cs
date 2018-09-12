using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{

    // Player Movement Variable
    public int MoveSpeed;
    private float JumpHeight;

    // Player Grounded Variable
    public Transform GroundCheck; // access modifier - data type (transform; position, rotation, scale) - 
    public float GroundCheckRadius;
    public LayerMask WhatIsGround;
    private bool Grounded; // if and else command

	// Use this for initialization
	void Start ()
    {
      
	}

    private void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);


    }

    // Update is called once per frame
    void Update ()
    {
        //this code makes character jump
        if(Input.GetKeyDown (KeyCode.Space)&& )
    }

    public void Jump()
    {
        GetComponent<>
    }

}
