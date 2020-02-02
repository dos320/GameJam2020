using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class core : MonoBehaviour
{
    public static float ship_health = 5000;
    public static float ship_oxygen = 100;
    public static float time_elapsed = 0;
    public static float garbageTimer = 0;
    public static float powerTimer = 0;
    public static float controlTimer = 0;
    public static float kitchenTimer = 0;
    public const float TIME_LIMIT = 120; // two minutes
    public const float TOTAL_SHIP_OXYGEN = 100;
    public const float TOTAL_SHIP_HEALTH = 5000;
    const float TIMER_CAP = 15;
    private float lastTime = 0;
    
    private static int gameState;
    // Start is called before the first frame update
    void Start()
    {
        gameState = 0;
        lastTime = Time.time; 
        //ship_health = 5000;
        //ship_oxygen = 100;
        //time_elapsed = 0; 

        // does not render the interaction information upon running the game
        GameObject.Find("Player1/InteractionSprite").GetComponent<Renderer>().enabled = false;
        GameObject.Find("Player2/InteractionSprite").GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if()
        GameObject.Find("UI/TimeLimitValue").GetComponent<Text>().text = TIME_LIMIT - Time.time+ "";
        
        if(Time.time - lastTime >= 0.5){
            if(controlTimer >= TIMER_CAP){
                controlTimer = 0;
                GameObject.Find("UI/controlIndicator")   
            }
            if(garbageTimer >= TIMER_CAP){
                garbageTimer = 0;
            }
            if(powerTimer >= TIMER_CAP){
                powerTimer = 0;
            }
            if(kitchenTimer >= TIMER_CAP){
                kitchenTimer = 0;
            }
            Debug.Log(timeElapsed + " " + currentRate);
            lastTime = Time.time;
            
            controlTimer += 1;
            garbageTimer += 1;
            powerTimer += 1;
            kitchenTimer += 1;
        }
    }
}
