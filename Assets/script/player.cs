using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour {
    private AudioSource audioSource;
    public bool isGround;
    public LayerMask groundLayer;	// 着地できるレイヤー 
    public bool isJump;
    public float move;
    bool isDead = false;
    bool isDeadStart = false;
    public GameObject mainCamera;//メインカメラ


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isDead)
        {
            GetComponent<BoxCollider2D>().enabled = false;  //コライダーを無効化
            GameObject.Find("MainText").SendMessage("GameOver");
        }
        else
        {
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
            /*if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += new Vector3(0f, 0.2f, 0);
            }*/
            /*if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += new Vector3(0f, -0.2f, 0);
            }*/
            if (Input.GetKey(KeyCode.Space) && isGround == true)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 150.0f, 0));
                isGround = false;
                isJump = true;
                GetComponent<AudioSource>().Play();
            }
            //GetComponent<Animator>().SetBool("isJump", isJump);
            //GetComponent<Animator>().SetFloat("move", move);
            RaycastHit2D hit = Physics2D.Linecast(
                    transform.position,           // 始点 
                    transform.position - transform.up * 1.0f, // 終点 
                groundLayer);
            /*if (hit.collider)
            {
                isGround = true;
                isJump = false;
            }
            */
        }
       // GetComponent<Animator>().SetBool("isDead", isDead);
    }
    void FixedUpdate()
    {
        if (isDead)
        {
            if (!isDeadStart)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500f);
                isDeadStart = true;
            }
        }

    }

    void Miss()
    {
        isDead = true;
    }
}
