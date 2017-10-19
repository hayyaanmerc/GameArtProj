using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {
    private float maxHP;
    private float attackPower;
    //private Collision col2D;

    public Movement move;
    public HealthHandler health;
	
	/*void OnCollisionEnter(Collision colInfo){
		if (colInfo.collider.ToString () == "Enemy") {
			print ("hit enemy");
		}
	}*/
	// Use this for initialization
	void Start () {
        move = GetComponent<Movement>();
        health = GetComponent<HealthHandler>();
            //col2D = GetComponent< Collision>();
            maxHP = 10;
	}

    public float getMaxHP()
    {
        return maxHP;
    }
    public void setMaxHP(float hp)
    {
        maxHP = hp;
    }
    public float getAttackPower()
    {
        return attackPower;
    }
    public void setAttackPower(float attack)
    {
        attackPower = attack;
    }
    // Update is called once per frame
    void Update () {
		//OnCollisionEnter (col2D);
		
	}
}
