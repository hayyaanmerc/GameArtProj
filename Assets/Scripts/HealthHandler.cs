using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour {

	public Movement playerInfo;
	//public Slider healthSlider;
	public Sprite healthSlider; 
	public float maxHP = 10;
	public float curHP;
	// Use this for initialization
	void Start () {
		//healthSlider = GetComponent<Slider> ();
		
		playerInfo = GetComponent<Movement> ();
		healthSlider = GetComponent<Sprite> ();
		//healthSlider.maxValue = maxHP;
		//healthSlider.pivot = new Vector2(0,0);
		curHP = maxHP;
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
