using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Requires a button to work
[RequireComponent(typeof(Button))] 
public class ClickSound : MonoBehaviour
{
    public AudioClip sound;
    // gets the required button component
    private Button btn { get { return GetComponent<Button>();} }    
    private AudioSource audioSource { get { return GetComponent<AudioSource>(); } }

    // Start is called before the first frame updates
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        audioSource.clip = sound;
        //playOnAwake 'might' be set to false by default.
        audioSource.playOnAwake = false;
        btn.onClick.AddListener(() => PlaySound());
    }

    // Plays the sound...
    void PlaySound()
    {
        audioSource.PlayOneShot(sound);
    }
}
