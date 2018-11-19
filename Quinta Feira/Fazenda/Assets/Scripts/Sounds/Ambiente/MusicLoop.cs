using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicLoop : MonoBehaviour
{
    public AudioClip[] audioBG;
    private AudioSource bgMusic1, bgMusic2, bgMusic3, AudioSource;

    private void Start()
    {
        AudioSource = gameObject.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (!bgMusic3.isPlaying && !bgMusic1.isPlaying)
        {
            AudioSource.clip = audioBG[1];
            AudioSource.Play();
        } 
        if (!bgMusic3.isPlaying && !bgMusic2.isPlaying)
        {
            AudioSource.clip = audioBG[0];
            AudioSource.Play();
        }
            
        if (!bgMusic1.isPlaying && !bgMusic2.isPlaying)
        {
            AudioSource.clip = audioBG[2];
            AudioSource.Play();
        }
    }
}
