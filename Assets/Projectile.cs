using UnityEngine;
using System.Collections;


public class Projectile : MonoBehaviour {
	public int damage = 1;
	public float projectileSpeed = 0.001f;

	// Use this for initialization
	void OnCollisionEnter(){
		Destroy (gameObject);
	}
	void Start () {
		Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (projectileSpeed, 0, 0);
	}
}
