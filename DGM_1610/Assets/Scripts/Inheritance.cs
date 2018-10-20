using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inheritance : MonoBehaviour {

    class Animal
    {
        public Animal()
        {
            print("Animal constructor");
        }
        public void Greet()
        {
            print("Animal says Hello");
        }
        public void Talk()
        {
            print("Animal talk");
        }
        public virtual void Sing()
        {
            print("Animal song");
        }
    };


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
