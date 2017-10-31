using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stun : MonoBehaviour
{
    public AI enemy;
    public EnemyHealth enemyDmg;
    private Vector3 playerposition;
    private float stunTime;
    private bool isStun;
    // Use this for initialization
    void Start()
    {
        enemy = GetComponent<AI>();
        stunTime = 1.5f;
    }
    private IEnumerator WaitforNext() //waits for the next stun
    {
        yield return new WaitForSeconds(1.0f);
        //Debug.Log("WaitForNextStun Done");
    }
    private IEnumerator WaitForStun()
    {
        yield return new WaitForSeconds(stunTime); //waits for the amount of seconds of stun
        enemy.resetSpeed();
        enemyDmg.resetDamage();
        isStun = false;
        // Debug.Log("WaitForNextStun Done");
        StartCoroutine(WaitforNext());
    }
    public bool checkStun()
    {
        if (enemy.Inrange(8))
            isStun = true;
            return isStun;
    }
    public void startStun()
    {
        if (checkStun())
        {
            enemy.SetSpeed(0);  //sets the enemies speed to 0
            enemyDmg.multiplyDamage(2);
            StartCoroutine(WaitForStun()); // Starts the wait time for stun
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            startStun();
        }

    }
}
