using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour {

    private float TimeStamp;
    public float coolDown = 3f;
    public GameObject projectile;
	// Use this for initialization
	void Start () {
        TimeStamp = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (TimeStamp <= Time.time)
        {
            
            GameObject bul = Instantiate(projectile, transform.position - new Vector3(1, 0, 0), Quaternion.identity) as GameObject;
            bul.transform.Translate(-1, 0, 0);
            TimeStamp = Time.time + coolDown;
            print("shooting");
            
        }
    }
}
