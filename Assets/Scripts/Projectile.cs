using UnityEngine;
using System.Collections;


public class Projectile : MonoBehaviour {
	public int damage = 1;
	public float projectileSpeed = 10.0f;

	// Use this for initialization
	void OnCollisionEnter(){
	Destroy(gameObject);
	}
	void Start () {
        Destroy (gameObject, 2);
       // gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0.5f, 0, 0);
	}
}
