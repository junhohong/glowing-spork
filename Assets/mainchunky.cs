using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainchunky : MonoBehaviour
{
    public Camera camera;
    Ray ray;
     RaycastHit hit;

 
     void Start () {
         ray = camera.ScreenPointToRay(Input.mousePosition);
     }
 
     void Update () {
         if (Input.GetMouseButtonDown (0)) {
             ray = camera.ScreenPointToRay (Input.mousePosition); 
             if (Physics.Raycast (ray, out hit)) {
                Debug.DrawLine(ray.origin, hit.point);
                Debug.Log ("main: Hit");
                Debug.Log("normal" + hit.normal);
                Debug.Log("transform" + hit.transform);
             } else {
                 Debug.Log("main: not hit");
             }
 
         }    
     }
 
}
