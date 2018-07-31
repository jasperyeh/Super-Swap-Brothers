using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    //Player starting position
    public Vector3 playerTwoPosition = new Vector3(0, 0, 0);
    public Vector3 playerOnePosition = new Vector3(0, 0, 0);
    //The CharacterControllers
    CharacterController playerOne;
    CharacterController playerTwo;

    public float speed = 10.0f;

    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("player1").GetComponent<CharacterController>();
        playerTwo = GameObject.FindGameObjectWithTag("player2").GetComponent<CharacterController>();
    }

    void Update()
    {
        if (this.gameObject.tag == "player1")
        {
            if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d"))
            {
                playerOnePosition = new Vector3(Input.GetAxis("p1h"), 0, Input.GetAxis("p1v"));
                playerOnePosition = transform.TransformDirection(playerOnePosition);
                playerOnePosition *= speed;
            }
        }

        if (this.gameObject.tag == "player2")
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                playerTwoPosition = new Vector3(Input.GetAxis("p2h"), 0, Input.GetAxis("p2v"));
                playerTwoPosition = transform.TransformDirection(playerTwoPosition);
                playerTwoPosition *= speed;
            }
        }

        playerOne.Move(playerOnePosition * Time.deltaTime);
        playerTwo.Move(playerTwoPosition * Time.deltaTime);
    }
}
