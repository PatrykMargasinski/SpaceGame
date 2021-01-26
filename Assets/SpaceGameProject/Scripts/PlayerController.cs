using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Movement movement;
    Shooting shooting;
    float newXmove=0;
    float newYmove=0;
    void Start()
    {
        movement=gameObject.GetComponent<Movement>();
        shooting=gameObject.GetComponent<Shooting>();
    }
    void KeyboardReader()
    {

        if(Input.GetKey(KeyCode.W))
        {
            newXmove=movement.moveX+Mathf.Cos(movement.transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            newYmove=movement.moveY-Mathf.Sin(movement.transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            movement.SetNews(newXmove,newYmove);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            newXmove=movement.moveX-Mathf.Cos(movement.transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            newYmove=movement.moveY+Mathf.Sin(movement.transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            movement.SetNews(newXmove,newYmove);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(0,-1f*Time.deltaTime*80,0);
        }
        else if(Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(0,1f*Time.deltaTime*80,0);
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
