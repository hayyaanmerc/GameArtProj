﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	private Transform enemyT;
	//private Rigidbody enemyR;
	private AI enemy;
	private bool dirRight;
	private bool isStun;
    private Vector2 direction;
<<<<<<< HEAD
<<<<<<< HEAD
    public bool isImmune;
	//private bool isStun = false;

	public float pos;
    //public CoinDrop coin;
=======
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
	//private bool isStun = false;

	public float pos;
    public CoinDrop coin;
<<<<<<< HEAD
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
	public Movement playerPosition;
	public EnemyHealth health;
	public GameObject obj;
	public Projectile pro;
	public PlayerInfo player; //use to grab info regarding player such as AttackPower
	public const int speed = 2; //changed speed to constant 
	public int newSpeed = speed; //created newspeed variable and update this instead of speed var which should stay constant.
	public int hp = 3;
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
    private void OnDestroy()
    {
        coin.dropCoin(gameObject.transform.position);
    }
<<<<<<< HEAD
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
    void OnCollisionEnter(Collision collisionInfo)
	{
       
		if (collisionInfo.gameObject.name.Equals ("Player"))
        {
          //  print("hit");
            changeDirection();
        }
         if(collisionInfo.gameObject.CompareTag("inGameWall")) {
           // print("wall");
            changeDirection();
		}
         if(collisionInfo.gameObject.CompareTag("Enemy"))
        {
            changeDirection();
        }
		if(collisionInfo.gameObject.name.Equals("Projectile(Clone)")){
<<<<<<< HEAD
<<<<<<< HEAD
           
                health.takeDamage(player.GetAttackPower());
                print(hp);
=======
			health.takeDamage(player.GetAttackPower());
			print(hp);
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
=======
			health.takeDamage(player.GetAttackPower());
			print(hp);
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
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
		//enemyR = GetComponent<Rigidbody> ();
		isStun = false;
        direction = Vector2.right;
	}
    void knockBack() //code will eventually knockback eniemes
    {
        //enemyT.transform.Translate(direction * Time.deltaTime * newSpeed);
    }
    void changeDirection()
    {
        if (dirRight == true) 
        {
            direction = Vector2.left; //changes direction left
            Move();
            dirRight = false;

        }
        else if (dirRight == false)
        {
            direction = Vector2.right;
            Move();
            dirRight = true;
        }
        Update();
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
    void Update() {

        if (Input.GetKeyDown(KeyCode.R))
        {
<<<<<<< HEAD
<<<<<<< HEAD
            //if(isSwordsman)
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9
=======
>>>>>>> 5ba1cc97ea913a23b327e5575430f13d7a4217d9

            if (Inrange(4))
            {
              //  print("range is working");
                health.takeDamage(player.GetAttackPower());
            }
        }
        if (Input.GetKey(KeyCode.P)) {
          //  print("p");

        }
        if (newSpeed != 0)
            isStun = false;

       
       
		if (transform.position.x >= pos + 5) {
            changeDirection();
		}
		if (transform.position.x <= pos - 5) {
            changeDirection();
		}
        Move();
        if (hp <= 0) {
			obj.SetActive(false);
		}

	}
    public void Move()
    {
        enemyT.transform.Translate(direction * Time.deltaTime * newSpeed);
    }
    /*public void moveLeft()
    {
        enemyT.transform.Translate(-direction * Time.deltaTime * newSpeed);
        //enemyR.AddForce (Vector2.right * speed);
    }
    public void moveRight()
    {
        enemyT.transform.Translate(direction * Time.deltaTime * newSpeed);
        //enemyR.AddForce (-Vector2.right * speed);
    }*/
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
