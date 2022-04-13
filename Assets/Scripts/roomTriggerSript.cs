using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomTriggerSript : MonoBehaviour
{
    private Room thisRoom;

    // Start is called before the first frame update
    void Start()
    {
        this.thisRoom = new Room();
        CORE.addRoom(this.thisRoom);
    }

    public void onTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("player"))
        {
            print("Player entered room" + this.gameObject.ToString());
        }
        else if(other.gameObject.tag.Equals("enemy"));
        {
            print("Entered room " + this.gameObject.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
