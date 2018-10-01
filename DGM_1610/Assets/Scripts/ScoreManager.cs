﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public static int Score;

    Text ScoreText;

	// Use this for initialization
	void Start () {
        ScoreText = GetComponent<Text>(); 

        Score = 0; //score reset 
	}
	
	// Update is called once per frame
	void Update () {
        if (Score < 0)
            Score = 0; //no less than 0
        ScoreText.text = " " + Score; //display score
	}

    public static void AddPoints (int PointsToAdd) 
    {
        Score += PointsToAdd; 
    }
}
