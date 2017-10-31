using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class current_skill : MonoBehaviour {
    public int skill_Num;
    public int str, dex, spell, fort;
    public Text Dis_val;
    public Text strT, dexT, spellT, fortT;
    // Use this for initialization
    void Start () {
        skill_Num = 2;
        str = 1;
        dex = 1;
        spell = 1;
        fort = 1;
	}
	
	// Update is called once per frame
	void Update () {
        Dis_val.text = skill_Num.ToString();
        strT.text = str.ToString();
        dexT.text = dex.ToString();
        fortT.text = fort.ToString();
        spellT.text = spell.ToString();

    }
}
