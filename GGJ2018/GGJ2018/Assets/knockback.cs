using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockback : MonoBehaviour {
    public float xdir;
    public float ydir;
    public float thrust;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player1")
        {
            print("HIT");
            col.gameObject.GetComponent<Rigidbody2D>().AddForce(-gameObject.transform.right* 10);
            



        }
    }
}
