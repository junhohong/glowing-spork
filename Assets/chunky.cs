using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chunky : MonoBehaviour
{
  Ray ray;
     RaycastHit hit;
     public int number = 0;
     public GameObject Target;
 
     void Start () {
        //  // Initialise ray
        //  ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //  // Print out the current number value to the console window
        //  Debug.Log("Number is currently: " + number); 
     }
 
     void Update () {
        //  if (Input.GetMouseButtonDown (0)) {
        //      Debug.Log ("chunky: MouseDown");
        //      // Reset ray with new mouse position
        //      ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
        //      if (Physics.Raycast (ray, out hit)) {
        //         Debug.Log("chunky: hit");
 
        //      } else {
        //          Debug.Log("chunky: not hit");
        //      }
 
        //  }    
     }
 
}
