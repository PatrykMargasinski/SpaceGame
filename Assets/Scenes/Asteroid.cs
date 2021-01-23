using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hej");
        GameObject ship=col.gameObject;
        Movement temp=ship.GetComponent<Movement>();
        temp.moveX*=-0.7f;
        temp.moveY*=-0.7f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
