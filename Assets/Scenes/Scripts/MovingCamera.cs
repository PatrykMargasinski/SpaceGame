using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectToFollow;
    private Vector3 pos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos=objectToFollow.transform.position;
        pos.y=transform.position.y;
        transform.position=pos;
    }
}
