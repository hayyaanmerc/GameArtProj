using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpell : MonoBehaviour {
	Ray ray;
	RaycastHit hit;
	public GameObject prefab;
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
				GameObject obj=Instantiate(prefab,new Vector3(hit.point.x,hit.point.y + 1, 0), Quaternion.identity) as GameObject;
				

			}

		}



	}
}