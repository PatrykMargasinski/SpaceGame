using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement
{
    public GameObject playerShip;
    public float speed = 10f;
    float newXmove=0;
    float newYmove=0;
    public override void ChangeVelocityVector()
    {
        var targetPosition = playerShip.transform.position;
        targetPosition.y = gameObject.transform.position.y;
        gameObject.transform.LookAt(targetPosition);
        transform.Rotate(0,-90,0);
        if(Vector3.Distance(gameObject.transform.position,playerShip.transform.position)>5f)
        {
            newXmove=-Mathf.Cos(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*speed*Time.deltaTime;
            newYmove=-Mathf.Sin(transform.rotation.eulerAngles.y*Mathf.Deg2Rad)*speed*Time.deltaTime;
        }
        else
        {
            newXmove=0; newYmove=0;
        }
            SetNewVelocityVector(newXmove,newYmove);
    }
}
