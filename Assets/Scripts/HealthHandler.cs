using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHandler : MonoBehaviour {
	
	public Movement playerInfo;
	public Slider healthSlider;
	public float maxHP;
	public float curHP;
	// Use this for initialization
	void Start () {
		healthSlider.maxValue = playerInfo.GetMaxValue();  //get the max hp slider value
		maxHP = playerInfo.maxHP; //set the max hp value for slider.

		curHP = playerInfo.maxHP; //set the current hp to the max possible HP at the start
		healthSlider.value = curHP; //set the sliders value to the current hp
		healthSlider.minValue = 0; //min value = 0...
	}
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Z)) {

			curHP = curHP - 1;
			if (curHP < 0) {
				respawn ();
			}
			healthSlider.value = curHP;
		}*/


	}
	public void takeDamage(){
		curHP = curHP - 1; //decrement health upon taking damage 
		if (curHP <= 0) {
			curHP = 0;
			respawn (); //respawn when you hit 0
		}
		healthSlider.value = curHP;//reset 
	}
	public void respawn(){
		playerInfo.transform.position = new Vector3 (0, 2, 0);
		curHP = maxHP;
	}
}