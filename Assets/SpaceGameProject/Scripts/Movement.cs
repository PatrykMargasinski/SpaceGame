using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveX=0f;
    public float moveY=0f;
    bool moveChanging=false;
    public float maxVelocity=100f;
    public bool maxVelocityAchieved=false;
    public bool underCollision=false;

    void Update()
    {
        Move();
    }

    public void SetNews(float x, float y)
    {
        Debug.Log(GetVelocity(x,y)+ " "+GetVelocity());
        if(GetVelocity(x,y)>maxVelocity && GetVelocity(x,y)>GetVelocity())
        {
            var modificator=maxVelocity/GetVelocity(x,y);
            moveX=x*modificator;moveY=y*modificator;
        }
        else
        {
        moveX=x; moveY=y;
        }
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=moveX*Time.deltaTime;
        temp.z+=moveY*Time.deltaTime;
        gameObject.transform.position=temp;
    }
    public float GetVelocity()
    {
        return Mathf.Sqrt((moveX*moveX)+(moveY*moveY));
    }
    public float GetVelocity(float x, float y)
    {
        return Mathf.Sqrt((x*x)+(y*y));
    }
}
