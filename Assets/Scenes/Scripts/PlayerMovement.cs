using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Movement movement;
    void Start()
    {
        movement=gameObject.GetComponent<Movement>();
    }
    void KeyboardReader()
    {
        if(Input.GetKey(KeyCode.W))
        {
            movement.moveX+=Mathf.Cos(movement.rotation)*0.001f;
            movement.moveY-=Mathf.Sin(movement.rotation)*0.001f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            movement.moveX-=Mathf.Cos(movement.rotation)*0.001f;
            movement.moveY+=Mathf.Sin(movement.rotation)*0.001f;
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
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardReader();
    }
}
