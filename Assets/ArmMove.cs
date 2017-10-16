using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ArmMove : MonoBehaviour
{

    public float speed = 1.5f;
    private Quaternion target;

    void Start()
    {
    }

    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))//if mouse button is pressed then rotate arm 
                {
                gameObject.transform.Rotate(ArmMove.GetAngle(Vector2.gameObject));// Figure out how to find the angle between camera and the arm 
                
                
            }
        }
      //  transform.rotation = Quaternion.RotateTowards(trRotateansform.rotation, target, speed * Time.deltaTime);
    }

    private Vector3 GetAngle()
    {
        throw new NotImplementedException();
    }
}
