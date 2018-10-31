using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {
    public int PointsToAdd;

    void OnTriggerEnter2D (Collider2D Other)
    {

        if (Other.GetComponent<Rigidbody2D>() == null)
            return;

        if(Other.tag == "Player")
        {
            ScoreManager.AddPoints(PointsToAdd);

            Destroy(gameObject);
        }
    }

 
}
