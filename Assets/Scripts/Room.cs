using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room
{
    private Player thePlayer;
    private Enemy theEnemy;
    private GameObject currentRoomTrigger;

    public Room(GameObject currentRoomTrigger)
    {
        this.currentRoomTrigger = currentRoomTrigger;
        this.thePlayer = null;
        this.theEnemy = null;
    }

    public void setEnemy(Enemy e)
    {
        this.theEnemy = e;
        if(e.getRoom() != null)
        {
            Room enemysCurrentRoom = e.getRoom();
            CORE.destroyRoomGoGivenRoomTrigger(enemysCurrentRoom.getRoomTrigger());
        }
        this.theEnemy.setRoom(this);
    }

    public void setPlayer(Player p)
    {
        this.thePlayer = p;
        if(p.getRoom() != null)
        {
            Room playersCurrentRoom = p.getRoom();
            CORE.destroyRoomGoGivenRoomTrigger(playersCurrentRoom.getRoomTrigger());
        }
        this.thePlayer.setRoom(this); //let the player know they are in a new room
    }

    public Player getPlayer()
    {
        return this.thePlayer;
    }

    public GameObject getRoomTrigger()
    {
        return this.currentRoomTrigger;
    }
}
