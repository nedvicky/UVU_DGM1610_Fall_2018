using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour {


    //int coins[] = new int {1, 20, 15, 7, 2 };  //EXAMPLE OF HOW TO START AN ARRAY

    enum Inventory { cheese = 2, meat = 6, sword = 1, map = 1, world_runes = 3, spell_books = 23 }; //how to start an enum

    // Use this for initialization
    void Start ()
    {
        print("You have " + Inventory.cheese);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
