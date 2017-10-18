using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 10f; 
	public float jumpForce = 300f;
	public float maxHP = 10;
	public float curHP;
	public bool facingRight;

	private Collision col2D; 
	private Rigidbody rb;
	private SpriteRenderer sprite;
	private Transform spriteTransform;
	private Respawn spawner;
	public HealthHandler hp;

	
	private bool canJump = true;
	void OnCollisionEnter(Collision collisionInfo)
	{
		canJump = true;
		if (collisionInfo.collider.name.Equals("Enemy")) {
			hp.takeDamage ();
			//rb.AddForce (new Vector3 (0, 180, 0));
		}
		/*print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);*/
	}
	public float GetMaxValue(){
		return maxHP;
	}
	void Start ()
	{
		spawner = GetComponent<Respawn> ();
		rb = GetComponent<Rigidbody>();
		col2D = GetComponent<Collision>(); 
		hp = GetComponent<HealthHandler>();
		facingRight = true;
	}

	void FixedUpdate ()
	{
		
		//OnCollisionEnter (col2D);
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			transform.Translate (Vector3.right * Time.deltaTime * speed);
		
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			if (facingRight == true) {
				print ("moving right");
				transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, transform.localScale.z);
				facingRight = false;
			}
			transform.Translate (Vector3.left * Time.deltaTime * speed);
		}
		//jump code
		if ((Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow))/* && canJump == true*/) {
			if(canJump == true){
				canJump = false;
				rb.AddForce (new Vector3 (0, 1, 0) * jumpForce);				
			}
		}
		if (Input.GetKey (KeyCode.E)) {
			transform.Translate(new Vector3(2, 0, 0));
		}
	}
}