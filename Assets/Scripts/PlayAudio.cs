using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        aSource.Play();
    }
}