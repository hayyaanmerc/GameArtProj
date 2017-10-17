using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	private Transform enemyT;
	private Rigidbody enemyR;

	private bool dirRight;
	public int speed = 2;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name.Equals ("Cube")) {
			//dirRight = false;
		}
		/*print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);*/
	}
	// Use this for initialization
	void Start () {
		dirRight = true;
		enemyT = GetComponent<Transform> ();
		enemyR = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (dirRight == true) {
			//print ("GOING RIGHT?");
			transform.Translate (Vector2.right * Time.deltaTime * speed);
		} else {
			transform.Translate (-Vector2.right * Time.deltaTime * speed);
		}
		if (transform.position.x >= 20.0f) {
			dirRight = false;
		}
		if (transform.position.x <= 10.0f) {
			dirRight = true;
		}
	}
}
