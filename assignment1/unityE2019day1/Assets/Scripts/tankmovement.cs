using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankmovement : MonoBehaviour
{

    AudioSource audio;
    float horizontalSpeed = 40f;


    // Start is called before the first frame update
    void Start()
    {
     
        audio = GameObject.Find("GameManager").GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X") * Time.deltaTime;

        transform.Rotate(0, h, 0);

        if (Input.GetKeyDown(KeyCode.W))
        {
            audio.Play();
                   }
        if (Input.GetKeyUp(KeyCode.W))
        {
            audio.Stop();
        }
     
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 1);
        }
       
        
    }
    
  
}
