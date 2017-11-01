using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour {
    PlayerInfo Player;
    public GameObject coin;
<<<<<<< HEAD
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
            
=======
    void OnTriggerEnter(Collider info)
    {
        if (info.name.Equals("Player"))
        {
            //print ("touchie");
           // Player.heal();
           // gameObject.SetActive(false);
            Destroy(gameObject);
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
        }
    }
    public void dropCoin(Vector3 enemyPos)
    {
<<<<<<< HEAD
        drop = Instantiate(gameObject, enemyPos + new Vector3(2,0, 0) , Quaternion.identity) as GameObject;
        timeStamp = Time.time + despawnTime;
        //coin.SetActive(true);
    }
    public void Despawn()
    {
        Destroy(drop);
    }
=======
        GameObject drop = Instantiate(coin, enemyPos + new Vector3(2,0, 0) , Quaternion.identity) as GameObject;
        //coin.SetActive(true);
    }
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
    // Use this for initialization
    void Start () {
		
	}
<<<<<<< HEAD
    
	// Update is called once per frame
	void Update () {
		if(timeStamp <= Time.time)
        {
            Despawn();
        }
=======
    ~CoinDrop()
    {
        Destroy(gameObject);
        print("End");
    }
	// Update is called once per frame
	void Update () {
		
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
	}
}
