using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;
    public int num;
    private Rigidbody rb;
    public float xMin = -50;
    public float xMax = 50;
    public float zMin = -50;
    public float zMax = 50;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            CORE.display();
            count++;
            if(count == 3)
            {
                //this.gameObject.SendMessage("DoSomething");
                Destroy(this.gameObject);
            }
        }
    }

    void Update()
    {
        float randomX = Random.Range(xMin, xMax);
        float randomZ = Random.Range(zMin, zMax);
        Vector3 target = new Vector3(randomX, 0, randomZ);

        int randomNum = Random.Range(1,4);
        if  (randomNum == 1)
        {
            rb.velocity = target * speed;
        }
        else if (randomNum == 2)
        {
            rb.velocity = target * speed;
        }
        else if (randomNum == 3)
        {
            rb.velocity = target * speed;
        }
        else if (randomNum == 4)
        {
            rb.velocity = target * speed;
        }
    }
}