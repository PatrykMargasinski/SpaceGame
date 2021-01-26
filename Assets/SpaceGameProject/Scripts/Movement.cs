using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveMultiplier=1f;
    public float moveX=0f;
    public float moveY=0f;
    public float newX=0f;
    public float newY=0f;
    bool moveChanging=false;
    Vector2 currentPosition;
    public float rotation=0f;
    public float maxVelocity=100f;
    public bool maxVelocityAchieved=false;
    public bool underCollision=false;
    public float velocity;
    // Start is called before the first frame update
    void Awake()
    {
        currentPosition=new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(moveChanging) SetNewMoveValues();
        Move();
        CheckCollision();
    }
    void SetNewMoveValues()
    {
        moveX=newX; moveY=newY;
        moveChanging=false;
    }

    public void SetNews(float x, float y)
    {
        newX=x; newY=y;
        moveChanging=true;
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=moveX*Time.deltaTime*moveMultiplier;
        temp.z+=moveY*Time.deltaTime*moveMultiplier;
        gameObject.transform.position=temp;
        currentPosition.x=temp.x;
        currentPosition.y=temp.z;
        velocity=Mathf.Sqrt((moveX*moveX)+(moveY*moveY));
    }

    void CheckCollision()
    {
        foreach(ICollisional collisional in SpaceGameManager.activeObjects)
        {
            if(GetDistance(currentPosition,collisional.GetPosition())<collisional.GetRadius()+0.5f)
            {
                if(underCollision==false)
                {
                    Debug.Log("Collision: "+GetDistance(currentPosition,collisional.GetPosition()));
                    collisional.CollisionReaction(this);
                    underCollision=true;
                }
                return;
            }
        }
        underCollision=false;
    }

    float GetDistance(Vector2 v1, Vector2 v2)
    {
        return Mathf.Sqrt((v1.x-v2.x)*(v1.x-v2.x)+(v1.y-v2.y)*(v1.y-v2.y));
    }
    public float GetVelocity()
    {
        return velocity;
    }
}
