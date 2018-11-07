using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public CharacterMove Protagonist;

    public bool isFollowing;


    //camera position offset
    public float xOffset;
    public float yOffset;


	// Use this for initialization
	void Start ()
    {
        Protagonist = FindObjectOfType<CharacterMove>();

        isFollowing = true;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isFollowing)
        {
            transform.position = new Vector3(Protagonist.transform.position.x + xOffset, Protagonist.transform.position.y + yOffset, transform.position.y);
        }
		
	}
}
