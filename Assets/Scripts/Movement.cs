using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 10f; 
	public float jumpForce = 300f;
	public float maxHP = 10;
	public float curHP;
	public bool facingRight;
	public float dashDist = 10f;

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
		if(collisionInfo.collider.name.Equals("Projectile")){
			hp.takeDamage();
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
				//sprite.flipX= true;
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
		if (Input.GetKeyDown (KeyCode.E)) {
			Dash ();
			//rb.velocity = new Vector2 (rb.velocity.x * 30, rb.velocity.y);
			//transform.position += Vector3.Lerp (new Vector3 (transform.position.x, transform.position.y, 0), new Vector3 (transform.position.x + 3, transform.position.y, 0),3.0f);
			//rb.AddRelativeForce (Vector3.right * 1000);
			//transform.Translate(Vector3.right*speed*10);




		}
	}
	public void Dash(){
		var DashPos = transform.position; 
		float t = 0f;

		DashPos.x = transform.position.x + dashDist;

		while (t < 1) {
			t += Time.deltaTime * 2;
			//print ("t= " + t);
			transform.position = Vector3.Lerp (transform.position, DashPos, t);

		}
	}
}