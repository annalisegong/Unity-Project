using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    private Room currentRoom;
    private Room previousRoom;

    public Enemy()
    {
        this.currentRoom = null;
    }

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public void setPreviousRoom(Room r)
    {
        this.previousRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }
    
    public Room getPreviousRoom()
    {
        return this.previousRoom;
    }
}