using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerScript : MonoBehaviour
{
    private Room thisRoom;

    void Awake()
    {
        print("*************** Room trigger is awake *************");
    }

    // Start is called before the first frame update
    void Start()
    {
        print("*************** Room trigger has started *************");
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            this.thisRoom.setPlayer(CORE.getPlayer()); //lets the new room know about the player
            print("Player now in room: " + this.thisRoom);
        }
        else if(other.gameObject.tag.Equals("Enemy"))
        {
            this.thisRoom.setEnemy(CORE.getEnemy()); //lets the new room know about the enemy
            print("Enemy Entered room " + this.gameObject.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}