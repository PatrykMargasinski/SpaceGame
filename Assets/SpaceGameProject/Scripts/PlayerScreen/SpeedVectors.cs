using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedVectors : MonoBehaviour
{
    public GameObject ship;
    Movement movement;
    public Text info;
    public Image line;
    public Image middle;
    private float maxSize=60f;
    public Vector2 velocities=new Vector2();    
    void Start()
    {
        movement=ship.GetComponent<Movement>();
        velocities.y=movement.maxVelocity;
    }
    void Update()
    {
        SetVelocity();
        EditLineSize();
        MoveLine();
        RotateLine();
    }
    void SetVelocity()
    {
        velocities.x=movement.GetVelocity();
        info.text=$"V: {Mathf.Ceil(movement.GetVelocity()*100)}";
    }
    void EditLineSize()
    {
        line.rectTransform.sizeDelta=new Vector2(velocities.x/velocities.y*maxSize*50,2);
    }

    void MoveLine()
    {
        line.rectTransform.localPosition=new Vector2(velocities.x/velocities.y*maxSize*50/2,0);
    }

    void RotateLine()
    {
        if(Mathf.Abs(movement.GetVelocity())>=0.0001f)
        {
            float rot=Mathf.Atan(movement.moveY/movement.moveX);
            middle.transform.eulerAngles=new Vector3(0,0,rot*57.2957795f+(movement.moveX<0?180:0));
        }
    }
}