using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	private Transform enemyT;
	private Rigidbody enemyR;
	private AI enemy;
	private bool dirRight;

	public Movement player;
	public EnemyHealth health;
	public GameObject obj;
	public Projectile pro;
	public int speed = 2;
	public int hp = 3;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name.Equals ("Player")) {
			if (dirRight == true)
				dirRight = false;
			else if (dirRight == false)
				dirRight = true;
		}
		if(collisionInfo.collider.name.Equals("Projectile(Clone)")){
			health.takeDamage ();
			print (hp);
		}
		/*print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);*/
	}
	// Use this for initialization
	void Start () {
		dirRight = true;
		enemy = GetComponent<AI> ();
		enemyT = GetComponent<Transform> ();
		enemyR = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.P)) {
			print ("p");
			
		}
		if (dirRight == true) {
			//print ("GOING RIGHT?");
			enemyT.transform.Translate (Vector2.right * Time.deltaTime * speed);
			//enemyR.AddForce (Vector2.right * speed);
		} else {
			enemyT.transform.Translate (-Vector2.right * Time.deltaTime * speed);
			//enemyR.AddForce (-Vector2.right * speed);
		}
		if (transform.position.x >= 20.0f) {
			dirRight = false;
		}
		if (transform.position.x <= 10.0f) {
			dirRight = true;
		}
		if (hp <= 0) {
			Destroy (obj.gameObject);
		}
	
	}
}
