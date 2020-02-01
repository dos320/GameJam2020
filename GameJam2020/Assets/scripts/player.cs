using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    bool pickUp;
    void Start()
    {
        pickUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            pickUp = true;
        }
        else
        {
            pickUp = false;
        }

        if (pickUp)
        {

        }   
    }
}
