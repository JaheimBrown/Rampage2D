using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLLECTINGAUDIO : MonoBehaviour
{
    [SerializeField] private AudioClip clockClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Clock"))
        {
            audioSource.clip = clockClip;
            audioSource.Play(); 
        }
    }
}
