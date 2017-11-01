using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour {


	public GameObject projectile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			GameObject bul = Instantiate (projectile, transform.position + new Vector3(1,0,0), Quaternion.identity) as GameObject;
			bul.transform.Translate (1, 0, 0);
		}
		
	}
}
