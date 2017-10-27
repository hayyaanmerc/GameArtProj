using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	private Transform enemyT;
	private Rigidbody enemyR;
	private AI enemy;
	private bool dirRight;
	private bool isStun;
	//private bool isStun = false;

	public float pos;
	public Movement playerPosition;
	public EnemyHealth health;
	public GameObject obj;
	public Projectile pro;
	public PlayerInfo player; //use to grab info regarding player such as AttackPower
	public const int speed = 2; //changed speed to constant 
	public int newSpeed = speed; //created newspeed variable and update this instead of speed var which should stay constant.
	public int hp = 3;
	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.name.Equals ("Player") || collisionInfo.collider.name.Equals("GroundWall")) {
			if (dirRight == true)
				dirRight = false;
			else if (dirRight == false)
				dirRight = true;
		}
		if(collisionInfo.collider.name.Equals("Projectile(Clone)")){
			health.takeDamage(player.GetAttackPower());
			print(hp);
		}
		/*print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);*/
	}
	// Use this for initialization
	void Start () {
		pos = transform.position.x;
		dirRight = true;
		enemy = GetComponent<AI> ();
		enemyT = GetComponent<Transform> ();
		enemyR = GetComponent<Rigidbody> ();
		isStun = false;
	}
	public void SetSpeed(int speedChange)// function to set the speed of enemy to 0 
	{
		newSpeed = speedChange;
		if (newSpeed == 0)
			isStun = true;
	}
	public void resetSpeed() //resets the speed back to the original
	{
		newSpeed = speed;
		if (newSpeed != 0)
			isStun = false;
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.R))
		{

			if (Inrange(4))
			{
				print("range is working");
				health.takeDamage(player.GetAttackPower());
			}
		}
		if (Input.GetKey (KeyCode.P)) {
			print ("p");

		}
		if (newSpeed != 0)
			isStun = false;

		if (dirRight == true) {
			//print ("GOING RIGHT?");
			enemyT.transform.Translate (Vector2.right * Time.deltaTime * newSpeed);
			//enemyR.AddForce (Vector2.right * speed);
		} else {
			enemyT.transform.Translate (-Vector2.right * Time.deltaTime * newSpeed);
			//enemyR.AddForce (-Vector2.right * speed);
		}
		if (transform.position.x >= pos + 5) {
			dirRight = false;
		}
		if (transform.position.x <= pos - 5) {
			dirRight = true;
		}
		if (hp <= 0) {
			Destroy (obj.gameObject);
		}

	}
	public bool Inrange(float range) //function to tell if player is in range

	{
		Vector3 playerpos = playerPosition.transform.position;
		Vector3 Enenmypos = enemy.transform.position;
		float total = playerpos.x - Enenmypos.x;
		if (total < range && total > -range)
		{
			return true;
		}
		else return false;
	}
}
