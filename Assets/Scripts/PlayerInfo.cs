﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

	public int maxHP = 10;
	public int speed = 10; // subject to change, not official.
    private Collision col2D;
    private int attackPower = 1;
    void OnCollisionEnter(Collision colInfo){
	}
	// Use this for initialization
	void Start () {
		col2D = GetComponent<Collision>();
	}
    public int GetAttackPower()
    {
        return attackPower;
    }
    public void MultiplyAttackPower(int multipier)// used to multiply attack values subject to change if we arent using multipliers
    {
        attackPower = multipier * attackPower;
    }

    // Update is called once per frame
    void Update () {
		
		
	}
}
