using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {

	public AI enemyInfo;
	public Slider healthSlider;
	public int maxHP;
	public int curHP;
	// Use this for initialization
	void Start () {
		
		maxHP = enemyInfo.hp;
		curHP = maxHP;
		healthSlider.maxValue = maxHP;
		healthSlider.value = curHP;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void takeDamage(){
		curHP = curHP - 1; //decrement health upon taking damage 
		healthSlider.value = curHP;
		if (curHP <= 0) {
			curHP = 0;
			Destroy (enemyInfo.gameObject);

		}
		//regenerate (); 
	}
}
