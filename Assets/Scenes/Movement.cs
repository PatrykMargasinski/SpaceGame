using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveX=0f;
    public float moveY=0f;
    float rotation=0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Sin(Mathf.PI/2f));
    }

    // Update is called once per frame
    void Update()
    {
        KeyboardReader();
        Move();
        //Debug.Log(moveX+" "+moveY);
    }

    void KeyboardReader()
    {
        if(Input.GetKey(KeyCode.W))
        {
            moveX+=Mathf.Cos(rotation)*0.001f;
            moveY-=Mathf.Sin(rotation)*0.001f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            moveX-=Mathf.Cos(rotation)*0.001f;
            moveY+=Mathf.Sin(rotation)*0.001f;
        }
        if(Input.GetKey(KeyCode.Q))
        {
            gameObject.transform.Rotate(0,-1f,0);
            rotation=gameObject.transform.rotation.eulerAngles.y*0.0174532925f;
        }
        else if(Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(0,1f,0);
            rotation=gameObject.transform.rotation.eulerAngles.y*0.0174532925f;
        }
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=moveX;
        temp.z+=moveY;
        gameObject.transform.position=temp;
    }
}
