using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private bool playerClose;
    private GameObject[] closePlayers;
    private int closePlayersNum;

    private bool pickUp = false;
    private bool pickUp2 = false;
    private int  pickUpInc = 0;
    private int  pickUpInc2 = 0;
    void Start()
    {
        playerClose = false;
        closePlayers = new GameObject[2];
        closePlayersNum = 0;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.name);
        other.gameObject.transform.Find("InteractionSprite").GetComponent<Renderer>().enabled = true;
        closePlayers[closePlayersNum] = other.gameObject;
        closePlayersNum++;
        checkIfPlayerCloseEmpty();
    }

    private void OnTriggerExit2D(Collider2D other) {
        Debug.Log("exit"+ " " + closePlayersNum);
        other.gameObject.transform.Find("InteractionSprite").GetComponent<Renderer>().enabled = false;
        closePlayers[closePlayersNum] = null;
        closePlayersNum--;
        checkIfPlayerCloseEmpty();
    }

    private void checkIfPlayerCloseEmpty(){
        if(closePlayersNum == 0){
            playerClose = false;
        }else{
            playerClose = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerClose);

        //Pick up objects
        if (Input.GetKeyDown("e") && playerClose == true && gameObject.tag == "Pickup")
        {
            pickUpInc++;
            if (pickUpIncrement % 2 == 0)
            {
                pickUp = false;
            }
            else
            {
                pickUp = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad0) && playerClose == true && gameObject.tag == "Pickup")
        {
            pickUpInc2++;
            if (pickUpInc2 % 2 == 0)
            {
                pickUp2 = false;
            }
            else
            {
                pickUp2 = true;
            }
        }

        if (playerClose == true && pickUp == true && gameObject.tag == "Pickup")
        {
            transform.position = GameObject.FindGameObjectWithTag("Player1").transform.position;
        }
        else if (playerClose == true && pickUp2 == true && gameObject.tag == "Pickup")
        {
            transform.position = GameObject.FindGameObjectWithTag("Player2").transform.position;
        }
    }

}
