using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class handleOxygenSliderChange : MonoBehaviour
{
    // Start is called before the first frame update
    //public Slider OxygenBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(GameObject.Find("OxygenBar_fill").GetComponent<Slider>().value != null){
          //  Debug.Log(GameObject.Find("OxygenBar_fill").GetComponent<Slider>().value);
        //}

        Slider slider = transform.GetChild(0).GetComponent<Slider>();

        //Debug.Log(slider.value);
        
        //Debug.Log(OxygenBar.value);
        slider.value = core.ship_oxygen / 100;  
        
    }
}
