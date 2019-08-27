using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    private Button btn { get { return GetComponent<Button>(); } }

    // Start is called before the first frame update
    void Start()
    {
        btn.onClick.AddListener(() => spawnCube());
    }

    private void spawnCube()
    {
        Instantiate(cube, new Vector3(0, 9, 0), Quaternion.identity);
    }
}
