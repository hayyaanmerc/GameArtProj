using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour {

    //public Movement playerInfo;
	public Slider healthSlider;
    //public Sprite healthSlider; 
    public float maxHP;
	public float curHP;
	// Use this for initialization
	void Start () {
		//healthSlider = GetComponent<Slider> ();

		//Here's what I did r
	/*here*/	Movement playerInfo = GetComponent<Movement>(); //once you seperate movement class and player info class change Movement to Playerinfo
    /*and*/    healthSlider.maxValue = playerInfo.maxHP;
	/*here*/	maxHP = playerInfo.maxHP;
		//healthSlider.pivot = new Vector2(0,0);
		curHP = playerInfo.maxHP;


		//healthSlider.minValue = 0;
		//healthSlider.anchorMax = maxHP;
		//healthSlider.value = curHP;




	}
	
	// Update is called once per frame
	void Update () {
        
		if (Input.GetKeyDown (KeyCode.Z)) {
			
			curHP = curHP - 1;
			if (curHP < 0)
				curHP = 0;
			//transform.localScale.x = curHP;
			//healthSlider.value = curHP;
		}

	}
}
