using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour {
    private AudioSource audioSource;
    public bool isGround;
  
    public bool isjump;
    public float move;
    
    public GameObject mainCamera;//メインカメラ


    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        move = 0;
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
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 300.0f, 0));
            isGround = false;
            isjump = true;
        }
        GetComponent<Animator>().SetBool("isjump", isjump);
        GetComponent<Animator>().SetFloat("move", move);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        isjump = false;

    }

}
    

