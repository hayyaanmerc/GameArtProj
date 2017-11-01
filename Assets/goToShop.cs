using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToShop : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Application.LoadLevel("shop");
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
