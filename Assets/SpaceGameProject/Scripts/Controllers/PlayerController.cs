using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller, ICollisional, IShooter
{
    float newXmove=0;
    float newYmove=0;
    bool underCollision=false;
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

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Update()
    {
        KeyboardReader();
        CheckCollision();
    }
    //ICollisional
    public Vector3 GetPosition()
    {
        return transform.position;
    }
    public float GetRadius()
    {
        return 0.5f;
    }
    public void CollisionReaction(Movement movement)
    {
        movement.SetNews(-movement.moveX,-movement.moveY);
    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }
    //IShooter
    public void Shoot()
    {
        shooting.Shoot();
    }

    void CheckCollision()
    {
        foreach(ICollisional col in SpaceGameManager.activeObjects)
        {
            if(Vector3.Distance(GetPosition(),col.GetPosition())<=GetRadius()+col.GetRadius() && underCollision==false && col!=(ICollisional)this)
            {
                col.CollisionReaction(this.movement);
                underCollision=true;
                return;
            }
        }
        underCollision=false;
    }
}
