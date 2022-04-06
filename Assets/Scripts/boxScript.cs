using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    Vector3 goUp, doDown, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    private int count;

    // Start is called before the first frame update
    void Start() // similar to constructor
    {
        count = 0;
    }

    /*void OnCollisionExit(Collision collision)
    [
        print("box collision exit");
    ]*/
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;    
            if(count == 3)
            {
                this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}