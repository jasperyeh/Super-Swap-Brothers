using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapCollision : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "player1")
        //{
        //    print("COLLISIONP1");
        //    Vector3 temp = player1.transform.position;
        //    player1.transform.position = player2.transform.position;
        //    player2.transform.position = temp;
        //}
        //if(collision.gameObject.tag == "player2")
        //{
        //    print("COLLISIONP2");
        //    print("P2 Position Before: " + player2.transform.position);
        //    Vector3 temp = player2.transform.position;
        //    player2.transform.position = player1.transform.position;
        //    player1.transform.position = temp;
        //    print("P2 Position After: " + player2.transform.position);

        //    Destroy(gameObject);
        //}
        if (collision.gameObject.tag == "player2")
        {
            print("Swap player1 and player2 positions");
            Vector3 temp = player2.transform.position;
            player2.transform.position = player1.transform.position;
            player1.transform.position = temp;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "player3")
        {
            print("Swap player1 and player3 positions");
            Vector3 temp = player3.transform.position;
            player3.transform.position = player1.transform.position;
            player1.transform.position = temp;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "player4")
        {
            print("Swap player1 and player4 positions");
            Vector3 temp = player4.transform.position;
            player4.transform.position = player1.transform.position;
            player1.transform.position = temp;
            Destroy(gameObject);
        }
    }
}
