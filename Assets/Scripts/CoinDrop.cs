using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour {
    PlayerInfo Player;
    public GameObject coin;
    private GameObject drop;
    public float despawnTime =2.5f;
    private float timeStamp; 
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
    public void dropCoin(Vector3 enemyPos)
    {
        drop = Instantiate(gameObject, enemyPos + new Vector3(2,0, 0) , Quaternion.identity) as GameObject;
        timeStamp = Time.time + despawnTime;
        //coin.SetActive(true);
    }
    public void Despawn()
    {
        Destroy(drop);
    }
    // Use this for initialization
    void Start () {
		
	}
    
	// Update is called once per frame
	void Update () {
		if(timeStamp <= Time.time)
        {
            Despawn();
        }
	}
}
