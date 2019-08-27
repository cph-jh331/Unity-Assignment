using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpController : MonoBehaviour
{
    private int count;
    public Text countText;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip pickUpSound;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        setCountText();
        gameObject.AddComponent<AudioSource>();
        source.clip = pickUpSound;
        source.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
            playSound();            
        }
        print(count);
    }

    private void setCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    private void playSound()
    {
        source.PlayOneShot(pickUpSound);        
    }
}
