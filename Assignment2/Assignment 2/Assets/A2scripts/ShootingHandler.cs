using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootingHandler : MonoBehaviour
{
    public GameObject bullet;
    public GameObject playerBarrel;
    public float speed;
    public int timeoutDestructor;


    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            GameObject clone = Instantiate(bullet, playerBarrel.transform.position, Quaternion.identity);
            clone.GetComponent<Rigidbody>().AddForce(transform.forward *speed);          
            Destroy(clone, timeoutDestructor);
        }
    }

    


}
