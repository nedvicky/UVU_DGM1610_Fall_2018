using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

    public int Num;
    public string Name;

	// Use this for initialization
	void Start ()
    {
        if (Num == 10)
        {
            print("You got 10 out of 300!");
        }
        else
        {
            print("Bite me.");
        }

        switch (Num)
        {
            case 1:
                print("You got " + Num + " out of 300!");
                break;

            case 3:
                print("You got " + Num + " out of 300!");
                break;

            case 6:
                print("You got " + Num + " out of 300!");
                break;

            case 10:
                print("You got " + Num + " out of 300!");
                break;

            default:
                print("I do not comprehend " + Num + ".");
                break;
        }

        switch (Name)
        {
            case "Jason":
                print("WElcoMe to Camp Crystal lake " + Name + ". -Love, Mother");
                break;

            case "Sabrina":
                print("Hope to see you at your Dark Baptism " + Name + ". -Love, Aunt Zelda");
                break;

            case "Harry":
                print("YOU'RE A WIZARD " + Name + "!");
                break;

            default:
                print("Check your priorities mortal!");
                break;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
