using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int hitPoints=10;
    void Start()
    {
        
    }    
    void Update()
    {
        if(hitPoints<=0)
        {
            Destroy(gameObject);
        }
    }
}
