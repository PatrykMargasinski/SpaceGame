using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveX=0f;
    public float moveY=0f;
    public float rotation=0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Mathf.Sin(Mathf.PI/2f));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        //Debug.Log(moveX+" "+moveY);
    }

    void Move()
    {
        var temp=gameObject.transform.position;
        temp.x+=moveX;
        temp.z+=moveY;
        gameObject.transform.position=temp;
    }
}
