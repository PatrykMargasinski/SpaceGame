using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class ShowFPS : MonoBehaviour {
     public GameObject ship;
     Movement shipMovement;
     Text fpsText;
     float deltaTime;
     float speed=0;

     void Start()
     {
         shipMovement=ship.GetComponent<Movement>();
         fpsText=gameObject.GetComponent<Text>();
     }
 
     void Update () {
         deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
         float fps = 1.0f / deltaTime;
         fpsText.text = Mathf.Ceil(fps)+$"\nSpeed: {Mathf.Ceil(shipMovement.GetVelocity()*100)}";
     }
 }
