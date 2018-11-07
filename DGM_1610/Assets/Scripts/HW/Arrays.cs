using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

    //we started with 0 and gave it 12 spaces
    public int[] Milk = new int[12];        //arrays hold multiple values

    public string[] Jedi;

    public string[] Pets;


    // Use this for initialization - 
    void Start ()
    {
        

        Milk[0] = 1;
        Milk[1] = 2;
        Milk[2] = 3;
        Milk[3] = 4;
        Milk[4] = 5;
        Milk[5] = 6;
        Milk[6] = 7;
        Milk[7] = 8;
        Milk[8] = 9;
        Milk[9] = 10;
        Milk[10] = 11;
        Milk[11] = 12;

        //this can contain different types of values

        print(Milk[8]);

        Jedi = new string[5]; //total length of the array

        Jedi[0] = "Rey";
        Jedi[1] = "Obi Wan Kenobi";
        Jedi[2] = "Mace Windu";
        Jedi[3] = "Kit Fisto";
        Jedi[4] = "Luke Skywalker";

        foreach(string item in Jedi) //safest loop to use because it only goes to the total length of the array
        {
            print("Jedi name is " + item);
        }


        Pets = new string[6];


        Pets[0] = "Dog";
        Pets[1] = "Cat";
        Pets[2] = "Turantula";
        Pets[3] = "Blue Jay";
        Pets[4] = "Kinkajou";
        Pets[5] = "Rat";

        foreach(string item in Pets)
        {
            print("The pet is a " + item);
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
