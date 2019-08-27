using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetectorHandler : MonoBehaviour
{

    public GameObject explositionFx;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Bullet"))
        {
            explositionFx = Instantiate(explositionFx, transform.position, transform.rotation);
            print("bummelum");
            Destroy(Enemy.gameObject);
            Destroy(explositionFx.gameObject, 2);
        }
    }
}
