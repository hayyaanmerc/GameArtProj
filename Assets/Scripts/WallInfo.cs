using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallInfo : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject prefab;
	public int counter = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ray=Camera.main.ScreenPointToRay(Input.mousePosition);

		if(Physics.Raycast(ray,out hit))
		{
			if(Input.GetKeyDown(KeyCode.Mouse0))
			{
				print ("clicked");
				if (counter < 1) {
					//Destroy (GameObject.Find(gameObject.name + "(Clone)"));
					//counter = 0;
					GameObject obj=Instantiate(prefab,new Vector3(hit.point.x,hit.point.y + 0.5f, 0), Quaternion.identity) as GameObject;
					counter++;

				}
			}
		}
		if (prefab.gameObject == null) {
			print ("shits gone");
			counter = 0;
		}

	}
}
