using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
        LevelManager = FindObjectOfType<LevelManager>();	
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("I'm working.");

        if(other.name == "Protagonist")
        {
            LevelManager.RespawnPlayer();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
