﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public int startingHealth = 100;            // The amount of health the player starts the game with.
    public int currentHealth;                   // The current health the player has.

    // Use this for initialization
    void Start ()
    {
        currentHealth = startingHealth;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}