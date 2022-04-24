using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class boxScript : MonoBehaviour
{
    private int count;
    public GameObject thePlayer;
    public GameObject theEnemy;
    private Vector3 playerPosition;
    private Rigidbody rb;
    public float speed = 20f;
    private NavMeshAgent agent; 
    private Room currentRoom;

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
        count = 0;
        rb = this.gameObject.GetComponent<Rigidbody>();
        agent = this.gameObject.GetComponent<NavMeshAgent>();
        this.currentRoom = null;
        //agent.speed = 20f;
        //agent.Warp(thePlayer.transform.position);
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