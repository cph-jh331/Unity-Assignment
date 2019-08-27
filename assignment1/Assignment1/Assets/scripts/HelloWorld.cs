using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    void Update()
    {
        ListenForF();
    }

    private void ListenForF()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            print("Respect");
        }
    }
}
