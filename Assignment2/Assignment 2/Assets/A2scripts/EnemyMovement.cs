using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float smoothing = 1f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while(Vector3.Distance(transform.position, target.position) > 5f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
            print("sker der noget?");
            yield return null;
        }
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
