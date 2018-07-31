using UnityEngine;
using System.Collections;

public class Player2Movement : MonoBehaviour
{
    public float speed = 2.5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}