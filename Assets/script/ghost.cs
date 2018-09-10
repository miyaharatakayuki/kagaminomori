using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour {
    private AudioSource audioSource;

    public float move;
    public float move2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        move = 0;
        move2 = 0;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.1f, 0, 0);
            GetComponent<SpriteRenderer>().flipX = false;
            move = 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
            GetComponent<SpriteRenderer>().flipX = true;
            move = 1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0f, 0.1f, 0);
            GetComponent<SpriteRenderer>().flipX = false;
            move2 = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0f, -0.1f, 0);
            GetComponent<SpriteRenderer>().flipX = true;
            move2 = 1f;
        }
        GetComponent<Animator>().SetFloat("move", move);
        GetComponent<Animator>().SetFloat("move2", move2);
    }
}
