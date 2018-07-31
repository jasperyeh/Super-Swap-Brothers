using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2shoot : MonoBehaviour {
    public GameObject shotPrefab;
    public Transform shotSpawn;
    public float maxSpeed = 25f;
    public Rigidbody2D shotRigid;
    public float nextFire;
    public float fireRate;
    
	// Use this for initialization
	void Start () {
        //Quaternion.Euler(new Vector3(0, 0, 1)))
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("b") && Time.time > nextFire)
        {
            //float angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
            //print("ANGEL: " + angle);

            //print("TESTRight");
            nextFire = Time.time + fireRate;
            Rigidbody2D bulletInstance = Instantiate(shotRigid, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
            bulletInstance.velocity = transform.right * maxSpeed;

        }
        if (Input.GetKeyDown("v") && Time.time > nextFire)
        {
            //float angle = Mathf.Atan2(horizontal, vertical) * Mathf.Rad2Deg;
            //print("ANGEL: " + angle);

            //print("TESTRight");
            nextFire = Time.time + fireRate;
            Rigidbody2D bulletInstance = Instantiate(shotRigid, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
            bulletInstance.velocity = -transform.right * maxSpeed;

        }
        //if(Input.GetAxis("Joystick Right X") < 0 && Time.time > nextFire)
        //{
        //    print("TESTLeft");
        //    nextFire = Time.time + fireRate;
        //    Rigidbody2D bulletInstance = Instantiate(shotRigid, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
        //    bulletInstance.velocity = -transform.right * maxSpeed;

        //}
    }

    public void fireBullet()
    {
        var bullet = Instantiate(
           shotPrefab,
           shotSpawn.position,
           shotSpawn.rotation
       );

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 6;
    }

}
