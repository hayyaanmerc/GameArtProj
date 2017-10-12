using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour {

	private int health = 10;
	private Collision col2D;
	void OnCollisionEnter(Collision colInfo){
		if (colInfo.collider.ToString () == "Enemy") {
			print ("hit enemy");
		}
	}
	// Use this for initialization
	void Start () {
		col2D = GetComponent<Collision>();
	}
	
	// Update is called once per frame
	void Update () {
		//OnCollisionEnter (col2D);
		
	}
}
