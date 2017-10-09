using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	private Transform Player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5) {
			transform.position = new Vector3 (0, 2, 0);
		}
	}
}
