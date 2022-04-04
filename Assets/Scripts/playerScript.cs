using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    0 references
    privte Player thePlayer;


    // Start is called before the first frame update
    void Start()
    {
        thePlayer = new Player("Mike");
    }

    // Update is called once per frame
    void Update()
    {
        print(thePlayer.getName());
    }
}
