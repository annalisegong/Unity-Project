using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 20f;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
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
        playerPosition = thePlayer.transform.position;
        rb.velocity = new Vector3(playerPosition.x, 0, playerPosition.z) * speed;
    }
}