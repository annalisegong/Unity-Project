using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private Player thePlayer; 
    private Rigidbody rb;
    public float speed = 20f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Mike");
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    public void display()
    {
        print("Player Script Display");
    }

    void OnCollisionEnter(Collision collision)
    {
        CORE.display();

        if(collision.gameObject.tag.Equals("enemy"))
        {
            count++;
            if(count == 3)
            {   
                this.thePlayer.addKill();
            }
           // print("player collision enter");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            rb.velocity = Vector3.forward * speed;
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
