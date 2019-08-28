using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetectorHandler : MonoBehaviour
{

    public GameObject explositionFx;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            explositionFx = Instantiate(explositionFx, transform.position, transform.rotation);
            print("bummelum");
            Destroy(explositionFx.gameObject, 2);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

}
