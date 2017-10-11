using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ArmMove : MonoBehaviour
{

    public float speed = 1.5f;
    private Vector3 target;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
