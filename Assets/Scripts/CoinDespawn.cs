using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDespawn : MonoBehaviour {

    void OnCollisionEnter(Collision info)
    {
        if (info.gameObject.name.Equals("Player"))
        {
            //print ("touchie");
            // Player.heal();
            // gameObject.SetActive(false);
            Despawn();

        }
    }
    public void Despawn()
    {
        Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
