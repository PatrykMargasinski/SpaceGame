using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    float mod=90f/300f;
    void Awake()
    {

    }
    void Update()
    {
        Vector3 shipPos=ship.transform.position;
        player.transform.localPosition=new Vector3(shipPos.x*mod,shipPos.z*mod,0f);
    }
    public Image player;
    public GameObject ship;
}