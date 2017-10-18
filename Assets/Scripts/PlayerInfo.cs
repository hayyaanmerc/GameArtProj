using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

	public int maxHP = 10;
	public int speed = 10; // subject to change, not official.
	private Collision col2D;
	void OnCollisionEnter(Collision colInfo){
	}
	// Use this for initialization
	void Start () {
		col2D = GetComponent<Collision>();
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
}
