using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_wall : MonoBehaviour {
    void OnCollisionEnter(Collision touch)
    {
        if (touch.gameobject.name.Equals("Player"))
        {
            Gameobject.setActive("False");
        }
    }
	// Use this for initialization
	void Start ()
    {
	    	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
