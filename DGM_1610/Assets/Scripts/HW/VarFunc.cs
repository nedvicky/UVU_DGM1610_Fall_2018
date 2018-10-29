using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarFunc : MonoBehaviour {

    private GameObject target;

    public void AssignNewTarget(GameObject _target){
        target = _target;

    
    }

    public float PlayerJump;

    public VarFunc(GameObject target, float playerJump)
    {
        this.target = target;
        bool PlayerJump = true;

    }


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
