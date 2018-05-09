using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Text>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Gameover()
    {
        GetComponent<AudioSource>().Play();
        gameObject.GetComponent<Text>().enabled = true;

    }
}
