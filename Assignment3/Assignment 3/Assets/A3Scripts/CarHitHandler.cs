using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CarHitHandler : MonoBehaviour
{
    public Text UItime;
    public float timer = 25f;

    void Update()
    {
        if (timer >= 0.0f)
        {
            timer -= Time.deltaTime;
            UItime.text = timer.ToString("F");
        } else
        {
            Destroy(gameObject);
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AddTime"))
        {
            timer += 10f;
        }
    }





}
