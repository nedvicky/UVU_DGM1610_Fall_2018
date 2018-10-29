using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustAdd : MonoBehaviour {

    // vaiable 1 and 2 has interger
    public int YouSuck;
    public int YouLost;
    
    int TotalOfHowYouSuck;

    //create function that is going to compute these two functions

    void Start()
    {
        CalcAdd();
    }

        public void CalcAdd()
        {
            Add(YouSuck, YouLost);
        }

        public void Add(int yousuck, int youlost)
        {
            TotalOfHowYouSuck = YouLost + YouSuck;
        }



        public static void Main(int TotalOfHowYouSuck)
        {
            Console.WriteLine(TotalOfHowYouSuck);
        }

}
