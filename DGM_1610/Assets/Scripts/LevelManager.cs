using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject CurrentCheckPoint;
    private Rigidbody2D Player;
    //these are all declarations
    //declaring particles
    public GameObject DeathParticles;
    public GameObject RespawnParticles;

    //respawn delay float
    public float RespawnDelay;

    //point penalty interger for death
    public int PointPenaltyOnDeath;

    //how much gravity on respawn so you dont punch through the dang ground
    private float GravityStore;

    // Use this for initialization
	void Start ()
    {
        Player = FindObjectOfType<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer() //spawn delay that the player activates themselves by dying.
    {
        StartCoroutine("RespawnPlayerCo"); //a background cycle that is similar to an update function
    }

    public IEnumerator RespawnPlayerCo()
    {
        //generate death BLOOD (particles adjustment)
        Instantiate(DeathParticles, Player.transform.transform.position, Player.transform.rotation);
        //hide player after death
        //Player.enabled = false;
        Player.GetComponent<Renderer>().enabled = false;
        //gravity reset (for when player died and is hiding)
        GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
        Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        // Point Penalty
        ScoreManager.AddPoints(-PointPenaltyOnDeath);
        //Debug Message
        Debug.Log("Player Respawn");
        //Respawn Delay
        yield return new WaitForSeconds(RespawnDelay);
        //Gravity Restore
        Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
        //Match Players transform position
        Player.transform.position = CurrentCheckPoint.transform.position;
        //Show Player
        //Player.enabled = true;
        Player.GetComponent<Renderer>().enabled = true;
        //Spawn Player
        Instantiate(RespawnParticles, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
    }
}
