using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed = 10f;
	public float jumpForce = 300f;

	private Collider col2D; 
	private Rigidbody rb;
	private SpriteRenderer sprite;
	private Transform spriteTransform;

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
		
		if ((Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.UpArrow))) {
			
			rb.AddForce (new Vector3 (0, 1, 0) * jumpForce);
			//transform.Translate (Vector3.up * Time.deltaTime * jumpForce);
		}
		
	

	}
	void handleJump(){
		
	}

}