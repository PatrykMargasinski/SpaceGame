using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveX=0f;
    public float moveY=0f;
    public float rotation=0f;
    public float maxVelocity=100f;
    public bool maxVelocityAchieved=false;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=moveX;
        temp.z+=moveY;
        gameObject.transform.position=temp;
        velocity=Mathf.Sqrt((moveX*moveX)+(moveY*moveY));
    }

    public float GetVelocity()
    {
        return velocity;
    }
}
