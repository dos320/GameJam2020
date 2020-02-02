using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenDepleter : MonoBehaviour
{
    // Start is called before the first frame update
    private float[] rates;
    private float currentRate;
    private bool isFixed;
    public static float timeElapsed; 
    private float tempTime;
    private float lastTime = 0;
    
    void Start()
    {
      rates = new float[] {1, 2, 4};  
      currentRate = 0;
      isFixed = true;
      timeElapsed = Time.time;
      tempTime = Time.time; // gets time at running
    }

    // Update is called once per frame
    void Update()
    {
        // timer will reset upon interacting with the object.
       timeElapsed = Time.time - tempTime; 

       if(timeElapsed <= 5){
           currentRate = rates[0];
       }else if(timeElapsed <= 10 && timeElapsed > 5){
           currentRate = rates[1];
       }else if(timeElapsed <= 15 && timeElapsed > 10){
           currentRate = rates[2];
       }
        if(Time.time - lastTime >= 0.5){
            Debug.Log(timeElapsed + " " + currentRate);
            lastTime = Time.time;
            core.ship_oxygen -= currentRate;
        }
    }
}
