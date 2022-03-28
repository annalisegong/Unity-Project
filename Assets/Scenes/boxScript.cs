using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    Vector3 goUp, doDown, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() // similar to constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //this refers to the gameObject that hte script is attached to
        if(Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
            //print("space key was pressed")
        }
        else if(Input.GetKeyDown("down"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if(Input.GetKeyDown("left"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if(Input.GetKeyDown("right"))
        {
            rb.velocity = Vector3.right * speed;
        }
        else if(Input.GetKeyDown("space"))
        {
            rb.velocity = Vector3.up * speed;
        }
    }
}