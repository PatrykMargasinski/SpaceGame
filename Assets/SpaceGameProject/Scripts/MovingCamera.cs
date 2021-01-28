using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public GameObject ship;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var temp=ship.transform.position;
        temp.y=transform.position.y;
        transform.position=temp;
    }
}
