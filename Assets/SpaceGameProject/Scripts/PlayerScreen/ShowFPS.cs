using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class ShowFPS : MonoBehaviour {
     Text fpsText;
     float deltaTime;
     float speed=0;

     void Start()
     {
         fpsText=gameObject.GetComponent<Text>();
     }
 
     void Update () {
         deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
         float fps = 1.0f / deltaTime;
         fpsText.text = "FPS: "+Mathf.Ceil(fps);
     }
 }
