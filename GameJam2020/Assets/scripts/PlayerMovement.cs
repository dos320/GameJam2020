using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 movement;
    private float p1_horizontal;
    private float p1_vertical;
    private float p2_horizontal;
    private float p2_vertical;
    public float movement_speed;

    public Sprite move_up;
    public Sprite move_down;
    public Sprite move_right;
    public Sprite move_left;


    private Animator animator;
    void Start()
    {
        movement = Vector3.zero;
        animator = GetComponent<Animator>();
        Application.targetFrameRate = 200;
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("MoveSpeed", Mathf.Abs(Input.GetAxis("p1_Horizontal")));
        p1_horizontal = Input.GetAxis("p1_Horizontal");
        p1_vertical = Input.GetAxis("p1_Vertical");
        
        p2_horizontal = Input.GetAxis("p2_Horizontal");
        p2_vertical = Input.GetAxis("p2_Vertical");
        
        if(this.name == "Player1"){
            movement = new Vector3(p1_horizontal * movement_speed, p1_vertical * movement_speed, 0);
            transform.Translate(movement * Time.deltaTime);
        }else{
            movement = new Vector3(p2_horizontal * movement_speed, p2_vertical * movement_speed, 0);
            transform.Translate(movement * Time.deltaTime);
        }
        

        //player movement animation changing
        
    }
}
