using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour {

	public HealthHandler Player;
	void OnCollisionEnter(Collision info){
		if(info.collider.name.Equals("Player")){
			print ("touchie");
			Player.heal ();
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
