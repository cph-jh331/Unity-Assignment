using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float smoothing = 1;
    public Transform target;


    IEnumerable moveCoroutine()
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);
        }
        yield return new WaitForSeconds(3f);
    }

    // Start is called before the first frame update
    void Start()
    {
        /*
        StartCoroutine(moveCoroutine());
        */
    }

       
    // Update is called once per frame
    void Update()
    {
        
    }
}
