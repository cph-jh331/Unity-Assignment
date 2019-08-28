using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[
    RequireComponent(typeof(Button)), 
    RequireComponent(typeof(GameObject))
    ]
public class ResetButtonHandler : MonoBehaviour
{
    public GameObject car;
    private Vector3 originalPos;
    private Quaternion originalRot;
    
    private Button btn { get { return GetComponent<Button>(); } }
    // Start is called before the first frame update
    void Start()
    {
        originalPos = car.transform.position;
        originalRot = car.transform.rotation;
        btn.onClick.AddListener(() => resetPosition());
    }

    private void resetPosition()
    {
        car.transform.SetPositionAndRotation(originalPos, originalRot);
    }

}
