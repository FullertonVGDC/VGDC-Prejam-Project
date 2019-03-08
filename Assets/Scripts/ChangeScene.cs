using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
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

    public void StartMain(){
    	SceneManager.LoadScene("Main");
    }

    public void QuitGame(){
    	Application.Quit();
    }

    public void PlaySound(){
    	aSource.Play();
    }
}
