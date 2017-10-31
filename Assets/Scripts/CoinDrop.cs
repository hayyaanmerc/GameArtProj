using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour {
    PlayerInfo Player;
    public GameObject coin;
    void OnTriggerEnter(Collider info)
    {
        if (info.name.Equals("Player"))
        {
            //print ("touchie");
           // Player.heal();
           // gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    public void dropCoin(Vector3 enemyPos)
    {
        GameObject drop = Instantiate(coin, enemyPos + new Vector3(2,0, 0) , Quaternion.identity) as GameObject;
        //coin.SetActive(true);
    }
    // Use this for initialization
    void Start () {
		
	}
    ~CoinDrop()
    {
        Destroy(gameObject);
        print("End");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
