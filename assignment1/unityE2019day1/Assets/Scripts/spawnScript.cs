using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{

    public GameObject enemy;
    private GameObject spawnPos;
 
    // Start is called before the first frame update
    void Start()
    {
        spawnPos = GameObject.Find("SpawnPos");
    }

 

    public void onButton1Clicked()
    {
        Instantiate(enemy, spawnPos.transform.position, Quaternion.identity);
    }
}
