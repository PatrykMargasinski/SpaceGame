using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Movement : MonoBehaviour
{
    public float speedX=0f;
    public float speedY=0f;
    public float maxVelocity=100f;

    public abstract void ChangeVelocityVector();

    void Update()
    {
        Move();
        ChangeVelocityVector();
    }

    public void SetNewVelocityVector(float x, float y)
    {
        if(GetVelocity(x,y)>maxVelocity && GetVelocity(x,y)>GetVelocity())
        {
            var modificator=maxVelocity/GetVelocity(x,y);
            speedX=x*modificator;speedY=y*modificator;
        }
        else
        {
        speedX=x; speedY=y;
        }
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=speedX*Time.deltaTime;
        temp.z+=speedY*Time.deltaTime;
        gameObject.transform.position=temp;
    }
    public float GetVelocity()
    {
        return Mathf.Sqrt((speedX*speedX)+(speedY*speedY));
    }
    public float GetVelocity(float x, float y)
    {
        return Mathf.Sqrt((x*x)+(y*y));
    }
}
