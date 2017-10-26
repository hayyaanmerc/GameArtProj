using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

	private Transform enemyT;
	private Rigidbody enemyR;
	private AI enemy;
	private bool dirRight;
    private bool isStun;

	public Movement playerPosition;
	public EnemyHealth health;
	public GameObject obj;
	public Projectile pro;
    public PlayerInfo player;
	public const int speed = 2;
    public int newSpeed = speed;
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

        if (Input.GetKey (KeyCode.R))
        {

            if (Inrange())
            {
                print("range is working");
                health.takeDamage(player.GetAttackPower);
            }
         }
		if (Input.GetKey (KeyCode.P)) {
			print ("p");
			
		}
        if (newSpeed != 0)
            isStun = false;

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
    public bool Inrange()
    {
        Vector3 playerposition = player.transform.position;
        Vector3 Enenmyposition = enemy.transform.position;
        Vector3 total = playerposition - Enenmyposition;
        if (total.x < 3f && total.x > -3f)
        {
            return true;
        }
        else return false;
    }
}
