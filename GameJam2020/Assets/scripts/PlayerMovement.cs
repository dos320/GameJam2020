using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 movement;
    private float horizontal;
    private float vertical;
    public float movement_speed;

    void Start()
    {
        movement = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        movement = new Vector3(horizontal * movement_speed, vertical * movement_speed, 0);
        transform.Translate(movement * Time.deltaTime);
        
    }
}
