using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;
    public float xMin = -50;
    public float xMax = 50;
    public float zMin = -50;
    public float zMax = 50;
    public float speed = 3.0f;
    Vector3 moveRandom;

    private static List<GameObject> theRooms = new List<GameObject>();

    public static void addRoomGO(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("ouch");
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPos()
        {
            int x = Random.Range(-10,10);
            int z = Random.Range(-30,15);
            return new Vector3(x, 4, z);
        }
        
        for (int a = 0; a <=20; a++)
        {
            Instantiate(enemyPrefab, randomPos(), Quaternion.identity);
            float randomX = Random.Range(xMin, xMax);
            float randomZ = Random.Range(zMin, zMax);
            Vector3 target = new Vector3(randomX, 0, randomZ);
            enemyPrefab.position = target * speed * Time.deltaTime;        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}