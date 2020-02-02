using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    private Camera cam;
    public GameObject p1;
    public GameObject p2;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
