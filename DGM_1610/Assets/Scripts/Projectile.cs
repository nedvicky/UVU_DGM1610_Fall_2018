﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float Speed;
    public GameObject Protagonist;

    public GameObject EnemyDeath;

    public GameObject ProjectileParticle;

    public int PointsForKill;

    //public float ProjectileLife; //decimals

    public int TimeOut;


	// Use this for initialization
	void Start ()
    {
        Protagonist = GameObject.Find("Protagonist");//.GetComponent<Rigidbody2D>(); 

        EnemyDeath = Resources.Load("Prefab/Enemy Death Particle") as GameObject; //declaration of file

        ProjectileParticle = Resources.Load("Prefab/Projectile Particle") as GameObject;

        if (Protagonist.transform.localScale.x < 0)
            Speed = -Speed;

        //StartCoroutine(ProjectileLifeSpan());

        Destroy(gameObject, TimeOut);

        // Speed = Speed * Mathf.Sign(Protagonist.transform.localScale.x);

        // GetComponent<Rigidbody2D>().velocity = new Vector2(Speed + (Protagonist.GetComponent<Rigidbody2D>()
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy (other.gameObject);
            ScoreManager.AddPoints (PointsForKill);
        }

        //Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy (gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    //projectile life-span
    //IEnumerator ProjectileLifeSpan()
    //{
        //yield return new WaitForSeconds(ProjectileLife);
        //Destroy(gameObject);
    //}


}
