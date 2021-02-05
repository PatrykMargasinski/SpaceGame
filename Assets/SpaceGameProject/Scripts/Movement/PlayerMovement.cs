using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Movement
{
    float newXmove=0;
    float newYmove=0;
    public override void ChangeVelocityVector()
    {
        if(Input.GetKey(KeyCode.W))
        {
            newXmove=speedX+Mathf.Cos(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            newYmove=speedY-Mathf.Sin(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            SetNewVelocityVector(newXmove,newYmove);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            newXmove=speedX-Mathf.Cos(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            newYmove=speedY+Mathf.Sin(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*0.01f;
            SetNewVelocityVector(newXmove,newYmove);
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
}
