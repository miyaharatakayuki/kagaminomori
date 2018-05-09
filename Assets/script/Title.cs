using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour {
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Use this for initialization
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }
	
	// Update is called once per frame
	void Update () {
        //GetComponent<AudioSource>().Play();

    }
    public void PushStart()
    {
        GetComponent<AudioSource>().Play();
       

        SceneManager.LoadScene("scen1");
    }
}
