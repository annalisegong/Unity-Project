using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    public GameObject thePlayer;
    private Vector3 playerPosition;
    private NavMeshAgent agent; 
    private Room currentRoom;

    private Enemy theEnemy = new Enemy();
    private Rigidbody rb;
    public float speed = 20f;
    private int count;

     public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        CORE.setEnemy(theEnemy);
        rb = this.gameObject.GetComponent<Rigidbody>();
        count = 0;
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        //agent.speed = 20f;
        //agent.Warp(thePlayer.transform.position);
    }

    public Enemy getEnemy()
    {
        return this.theEnemy;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals("Player"))
        {
            count++;
            if(count == 3)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(thePlayer.transform.position);
    }
}