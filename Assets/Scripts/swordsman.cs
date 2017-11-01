using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordsman : MonoBehaviour {
    //public PlayerInfo info;
    bool isSwordman;

    public void OnMouseUpAsButton()
    {
        isSwordman = true;
        Application.LoadLevel("tutorial_scene");
    }
    public bool getSword()
    {
        return isSwordman;
    }
    // Use this for initialization
    void Start () {
        isSwordman = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
