using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
	private AudioSource aSource;

    // Start is called before the first frame update
    void Start()
    {
    	aSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(){
    	aSource.Play();
    }
}
