using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private string name;
    private int killCount;
    private Room currentRoom;
    private Room previousRoom;

    public Player(string name)
    {
        this.name = name;
        this.killCount = 0;
        this.currentRoom = null;
    }

    public void setRoom(Room r)
    {
        this.currentRoom = r;
    }

    public Room getRoom()
    {
        return this.currentRoom;
    }

    public void setPreviousRoom(Room r)
    {
        this.previousRoom = r;
    }

    public Room getPreviousRoom()
    {
        return this.previousRoom;
    }

    public void addKill()
    {
        this.killCount++;
    }

    public int getKillCount()
    {
        return this.killCount;
    }

    public string getName()
    {
        return this.name;
    }
}
