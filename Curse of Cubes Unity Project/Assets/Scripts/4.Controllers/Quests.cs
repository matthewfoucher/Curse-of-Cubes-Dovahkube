﻿using UnityEngine;
using System.Collections;

// Keeps track of all quests.
public class Quests : MonoBehaviour {

    public static int wandquest; //once it reaches level 1, the quest is complete
    public static int epicswordquest;
    public static int dovahkiid;
    public static int thieves;
    public static int dragon;

    public static int dragonCount; // How many dragon heads are alive.
	public static int thiefCount;
	public static int npcCount;

    public static bool flower;
    public static bool magic;
    public static bool blood;

    // Use this for initialization
    void Start () {
        wandquest = 0;
        epicswordquest = 0;
        dovahkiid = 0;
        flower = false;
        magic = false;
        blood = false;

        thieves = 0; 
		/*
		 2 means you've talked to thief
		 3 means you've aggro'd them by hitting either of them
		 4 means both dead
		 * */
        dragon = 0;
        /*
        1 means aggro
        2 means killed by dovahkube
        3 means killed by dovahkiid
        4 means suicide 
        5 means killed by dovahkube with regular sword.
        */

        dragonCount = 3;
		thiefCount = 2; 
		npcCount = 4;
    }
}
