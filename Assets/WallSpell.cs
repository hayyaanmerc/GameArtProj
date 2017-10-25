using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpell : MonoBehaviour {
	
	public GameObject prefab;
	public WallInfo info;
	//public Camera camera;
	// Use this for initialization
	void Start () {
		
		Destroy (prefab.gameObject, 2);
		info.counter--;

	}

	// Update is called once per frame
	void Update () {


	}
}