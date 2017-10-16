using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//using Respawn;

public class HealthHandler : MonoBehaviour {

	public Movement playerInfo;
	public Slider healthSlider;
	public Respawn spawner;
	//public Sprite healthSlider; 
	//public float maxHP = playerInfo.GetComponent<Movement>().maxHP;
	public float curHP;
	// Use this for initialization
	void Start () {
		healthSlider = GetComponent<Slider> ();
		spawner =  GetComponent<Respawn> ();
		playerInfo = GetComponent<Movement> ();
		//healthSlider = GetComponent<Sprite> ();
		healthSlider = playerInfo.GetComponent<Movement>();
		//healthSlider.pivot = new Vector2(0,0);
		curHP = healthSlider.maxValue;
		healthSlider.minValue = 0;
		//healthSlider.anchorMax = maxHP;
		healthSlider.value = curHP;




	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) {
			
			curHP = curHP - 1;
			if (curHP < 0)
				curHP = 0;
			//transform.localScale.x = curHP;
			healthSlider.value = playerInfo.curHP;
			if (curHP == 0) {
				print ("You died");
			}
		}



	}
	public void Hit(){
		curHP = curHP - 1;
	}

}
