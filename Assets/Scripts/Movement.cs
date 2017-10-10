using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 10f;
	public float jumpForce = 300f;

	private Collider col2D; 
	private Rigidbody rb;
	private SpriteRenderer sprite;
	private Transform spriteTransform;
	private bool canJump = true;
	void OnCollisionEnter(Collision collisionInfo)
	{
		print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
		print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
		print("Their relative velocity is " + collisionInfo.relativeVelocity);
	}
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		col2D = GetComponent<Collider>(); 
		
		//float speed = 10f;
	}

	void FixedUpdate ()
	{
		

		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
			transform.Translate (Vector3.right * Time.deltaTime * speed);
		
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			
			transform.Translate (Vector3.left * Time.deltaTime * speed);
		}
		//jump code
		if ((Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow)) && canJump == true) {
			if(canJump == true){
				rb.AddForce (new Vector3 (0, 1, 0) * jumpForce);
				//canJump = false; 
			}
			/*if(OnCollisionEnter(col2D)){
				canJump = true;
			}*/

		}
		
	

	}

}