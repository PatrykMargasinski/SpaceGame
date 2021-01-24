using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Movement movement;
    float oldVelocity=0;
    float newXmove=0;
    float newYmove=0;
    void Start()
    {
        movement=gameObject.GetComponent<Movement>();
    }
    void KeyboardReader()
    {

        if(Input.GetKey(KeyCode.W))
        {
            newXmove=movement.moveX+Mathf.Cos(movement.rotation)*0.001f;
            newYmove=movement.moveY-Mathf.Sin(movement.rotation)*0.001f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            newXmove=movement.moveX-Mathf.Cos(movement.rotation)*0.001f;
            newYmove=movement.moveY+Mathf.Sin(movement.rotation)*0.001f;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(0,-1f,0);
            movement.rotation=gameObject.transform.rotation.eulerAngles.y*0.0174532925f;
        }
        else if(Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(0,1f,0);
            movement.rotation=gameObject.transform.rotation.eulerAngles.y*0.0174532925f;
        }

        Debug.Log(ComputeVelocity(newXmove,newYmove)+ " "+movement.maxVelocity);

        if(ComputeVelocity(newXmove,newYmove)<movement.maxVelocity)
        {
            movement.moveX=newXmove;
            movement.moveY=newYmove;
        }
    }

    float ComputeVelocity(float a, float b)
    {
        return Mathf.Sqrt(a*a+b*b)*100;
    }
    // Update is called once per frame
    void Update()
    {
        KeyboardReader();
    }
}
