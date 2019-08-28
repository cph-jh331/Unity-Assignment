using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameObject))]
public class PowerUpMovement : MonoBehaviour
{
    public float speed = 20f;
    public float delay = 3f;
    public Transform[] path;
    public bool isRandom = false;
    private IEnumerator currentMoveRoutine;

    // Start is called before the first frame update
    void Start()
    {
        if (isRandom != true)
        {
            StartCoroutine(FollowPath());
        }
    }

    IEnumerator Move(Vector3 destination)
    {
        while (this.transform.position != destination)
        {
            //print(this + " is moving towards " + destination);
            this.transform.position = Vector3.MoveTowards(this.transform.position, destination, speed * Time.deltaTime);
            yield return null;
        }
        //print(this + "is waiting for " + delay);
        yield return new WaitForSeconds(delay);
    }

    IEnumerator FollowPath()
    {
        while (true)
        {
            foreach (Transform waypoint in path)
            {
                yield return StartCoroutine(Move(waypoint.position));
            }
        }
    }

    void FixedUpdate()
    {
        if (isRandom && Input.anyKeyDown)
        {
            if (currentMoveRoutine != null)
            {
                StopCoroutine(currentMoveRoutine);
            }
            currentMoveRoutine = Move(GenRandomDestination());
            StartCoroutine(currentMoveRoutine);
        }
    }

    private Vector3 GenRandomDestination()
    {
        float x = Random.Range(-100, 300);
        float y = Random.Range(50, 300);
        float z = Random.Range(-100, 300);
        return new Vector3(x, y, z);
    }

}

