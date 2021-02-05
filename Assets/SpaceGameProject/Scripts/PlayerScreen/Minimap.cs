using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    float mod=90f/300f;
    public Sprite sprite;
    void Awake()
    {
        //GetComponent<Image>();
    }
    void Update()
    {
        Vector3 shipPos=ship.transform.position;
        player.transform.localPosition=new Vector3(shipPos.x*mod,shipPos.z*mod,0f);
        coordinates.text=$"{Mathf.Ceil(shipPos.x*mod*100)},{Mathf.Ceil(shipPos.z*mod*100)}";
    }
    public Image player;
    public GameObject ship;
    public Text coordinates;
}