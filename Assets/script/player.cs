﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {
    SpriteRenderer MainSpriteRenderer;//スプライト画像管理
    public Sprite StandbySprite;
    public Sprite StandbySprite2;
    public Sprite StandbySprite3;
    public Sprite StandbySprite4;
    public Sprite StandbySprite5;
   

    public Sprite HoldSprite;
    public Sprite HoldSprite1;
    public Sprite HoldSprite2;
    public Sprite HoldSprite3;
    public Sprite HoldSprite4;

    public Sprite HoldSprite5;
    public Sprite HoldSprite6;
    public Sprite HoldSprite7;
    public Sprite HoldSprite8;
    public Sprite HoldSprite9;

    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;
    private AudioSource audioSource;

    public bool isJump;
    public float move;
    public bool isGround;
    public float move2;
    public static bool idle;
    public static bool gameOver = false;
    bool One;
    public static float meisuu=10;
    public Text timerText;
    public Text Text;
    public GameObject mainCamera;//メインカメラ
    public Life life;
    private new Renderer renderer;
    int seconds;
    int cnt = 0;
    int attackPoint = 10;
    int flg = -1;
    int flg2 = 0;
    public GameObject GameOverGUI;
    private Physics2D edge;
    private EdgeCollider2D e;
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;
    public bool push = false;
    // bool isDeadStart = false;
    // Use this for initialization
    void Start () {
        seconds = 0;
        idle = false;
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        maneg.flg = 0;
        renderer = GetComponent<Renderer>();
        gameOver = false;
        One = true;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        e = GetComponent<EdgeCollider2D>();
        flg2 = 0;
        meisuu = 10;
    }

    // Update is called once per frame
    void Update()
    {
        cnt++;

        if (gameOver)
        {
            // GetComponent<BoxCollider2D>().enabled = false;  //コライダーを無効化
            GameObject.Find("manegUI").SendMessage("GameOver");
            GameOverGUI.SendMessage("Gameover");
            gameOver = false;
        }
        else
        {
            cnt++;

            move = 0;
            move2 = 0;
            if (maneg.flg == 0)
            {

                if (One)
                {
                    gameObject.GetComponent<Rigidbody2D>().Resume(gameObject);
                    One = false;
                }
                

                if (!push)
                {
                    
                    if (Input.GetKey(KeyCode.RightArrow))
                    {



                        transform.position += new Vector3(0.1f, 0, 0);
                        GetComponent<SpriteRenderer>().flipX = false;
                        if (isJump == false)
                        {
                            move = 1f;
                        }
                        if (flg == -1)
                        {
                            MainSpriteRenderer.sprite = StandbySprite2;
                            if (cnt >= 10)
                            {
                                flg *= -1;
                                cnt = 0;
                            }
                        }
                        if (flg == 1)
                        {
                            MainSpriteRenderer.sprite = StandbySprite5;

                            if (cnt >= 10)
                            {
                                flg *= -1;
                                cnt = 0;
                            }
                        }

                    }
                    if (Input.GetKey(KeyCode.LeftArrow))
                    {

                        transform.position += new Vector3(-0.1f, 0, 0);
                        GetComponent<SpriteRenderer>().flipX = true;
                        move = 1;
                        if (isJump == true)
                        {
                            move = 0f;
                        }

                        //MainSpriteRenderer.sprite = StandbySprite3;
                        if (flg == -1)
                        {
                            MainSpriteRenderer.sprite = StandbySprite2;
                            if (cnt >= 10)
                            {
                                flg *= -1;
                                cnt = 0;
                            }
                        }
                        if (flg == 1)
                        {
                            MainSpriteRenderer.sprite = StandbySprite5;

                            if (cnt >= 10)
                            {
                                flg *= -1;
                                cnt = 0;
                            }
                        }
                    }
                }
                
                    
                    if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
                    {
                        push = true;
                    if (push)
                    {
                        GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 400.0f, 0));
                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector3(200.0f, 0.0f, 0));
                        }
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector3(-200.0f, 0.0f, 0));
                        }
                            isGround = false;
                        isJump = true;
                        if (isJump == true)
                        {
                            MainSpriteRenderer.sprite = StandbySprite4;
                            GetComponent<AudioSource>().Play();


                        }
                        
                    }
                    }
                    if (isGround == true && move == 0)
                    {
                        MainSpriteRenderer.sprite = StandbySprite;
                        isJump = false;
                        push = false;
                    }
                
                if (Input.GetKeyDown(KeyCode.F))
                {
                    
                    Panel.SetActive(true);
                   

                }
                if (Input.GetKeyDown(KeyCode.J))
                {

                    Panel.SetActive(false);

                }
                //画面中央から左に4移動した位置をユニティちゃんが超えたら
                /* if (transform.position.x > mainCamera.transform.position.x - 4)
                 {

                         //カメラの位置を取得
                         Vector3 cameraPos = mainCamera.transform.position;
                         //ユニティちゃんの位置から右に4移動した位置を画面中央にする
                         cameraPos.x = transform.position.x + 4;
                         mainCamera.transform.position = cameraPos;
                 }*/
                /*if (transform.position.y > mainCamera.transform.position.y - 2)
                {
                    //カメラの位置を取得
                    Vector3 cameraPos = mainCamera.transform.position;

                    cameraPos.y = transform.position.y ;
                    mainCamera.transform.position = cameraPos;
                }
                if (transform.position.y < mainCamera.transform.position.y + 2)
                {
                    //カメラの位置を取得
                    Vector3 cameraPos = mainCamera.transform.position;

                    cameraPos.y = transform.position.y ;
                    mainCamera.transform.position = cameraPos;
                }*/

                //カメラ表示領域の左下をワールド座標に変換
                //Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                //カメラ表示領域の右上をワールド座標に変換
                //Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                //ユニティちゃんのポジションを取得
                //Vector2 pos = transform.position;
                //ユニティちゃんのx座標の移動範囲をClampメソッドで制限
                // pos.x = Mathf.Clamp(pos.x, min.x + 0.5f, max.x);
                // transform.position = pos;




                //GetComponent<Animator>().SetBool("isJump", isJump);
                 GetComponent<Animator>().SetFloat("move", move);


              

            }
                

                if (maneg.flg == 1)
                {
              
                if (!One)
                  {
                    transform.position += new Vector3(0f, 0, 0);
                    gameObject.GetComponent<Rigidbody2D>().Pause(gameObject);
                    One = true;
                  }

               
                    MainSpriteRenderer.sprite = HoldSprite;

               
                   
                    /*rigidbody2D.velocity = Vector2.zero; // 2Dの場合
                    rigidbody.isKinematic = true;*/
                    meisuu -= Time.deltaTime;
                    seconds = (int)meisuu;

                    if (meisuu <= 0)
                    {
                        gameOver = true;
                       

                    }

                    timerText.text = seconds.ToString();
                    if (idle == true)
                    {


                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.position += new Vector3(0.2f, 0, 0);
                            GetComponent<SpriteRenderer>().flipX = false;
                            move2 = 1f;
                            MainSpriteRenderer.sprite = HoldSprite1;
                        }
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.position += new Vector3(-0.2f, 0, 0);
                            GetComponent<SpriteRenderer>().flipX = true;
                            move2 = 1f;
                            MainSpriteRenderer.sprite = HoldSprite2;
                        }
                        if (Input.GetKey(KeyCode.UpArrow))
                        {
                            transform.position += new Vector3(0f, 0.3f, 0);
                            MainSpriteRenderer.sprite = HoldSprite3;
                        }
                        if (Input.GetKey(KeyCode.DownArrow))
                        {
                            transform.position += new Vector3(0f, -0.2f, 0);
                            MainSpriteRenderer.sprite = HoldSprite4;
                        }
                        GetComponent<Animator>().SetFloat("move2", move2);
                        //画面中央から左に4移動した位置をユニティちゃんが超えたら
                        if (transform.position.x > mainCamera.transform.position.x - 4)
                        {
                            //カメラの位置を取得
                            Vector3 cameraPos = mainCamera.transform.position;
                            //ユニティちゃんの位置から右に4移動した位置を画面中央にする
                            cameraPos.x = transform.position.x + 4;
                            mainCamera.transform.position = cameraPos;
                        }
                        //カメラ表示領域の左下をワールド座標に変換
                        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
                        //カメラ表示領域の右上をワールド座標に変換
                        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
                        //ユニティちゃんのポジションを取得
                        Vector2 pos = transform.position;
                        //ユニティちゃんのx座標の移動範囲をClampメソッドで制限
                        pos.x = Mathf.Clamp(pos.x, min.x + 0.5f, max.x);
                        transform.position = pos;


                    }
                if (Input.GetKeyDown(KeyCode.F))
                {

                    Panel2.SetActive(true);


                }
                if (Input.GetKeyDown(KeyCode.J))
                {

                    Panel2.SetActive(false);

                }

            }

                if (maneg.flg == 2)
                {
               if( flg2 == 0) { 
                push = false;
                    e.enabled = false;
                    if (One)
                    {
                        gameObject.GetComponent<Rigidbody2D>().Resume(gameObject);
                        One = false;
                    }
                   
                    /*if (One)
                     {
                         transform.position = new Vector3(kisi.iti.x, kisi.iti.y, 0);
                         One = false;
                     }*/
                    MainSpriteRenderer.sprite = HoldSprite5;
                    if (!push)
                    {
                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            audioSource.clip = audioClip3;
                            audioSource.Play();
                            move = 1;
                            transform.position += new Vector3(0.1f, 0, 0);
                            GetComponent<SpriteRenderer>().flipX = false;
                            if (flg == -1)
                            {
                                MainSpriteRenderer.sprite = HoldSprite6;

                                if (cnt >= 20)
                                {
                                    flg *= -1;
                                    cnt = 0;
                                }
                            }
                            if (flg == 1)
                            {
                                MainSpriteRenderer.sprite = HoldSprite7;

                                if (cnt >= 20)
                                {
                                    flg *= -1;
                                    cnt = 0;
                                }
                            }

                        }
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            audioSource.clip = audioClip3;
                            audioSource.Play();
                            move = 1;
                            transform.position += new Vector3(-0.1f, 0, 0);
                            GetComponent<SpriteRenderer>().flipX = true;
                            if (flg == -1)
                            {
                                MainSpriteRenderer.sprite = HoldSprite6;

                                if (cnt >= 20)
                                {
                                    flg *= -1;
                                    cnt = 0;
                                }
                            }
                            if (flg == 1)
                            {
                                MainSpriteRenderer.sprite = HoldSprite7;

                                if (cnt >= 20)
                                {
                                    flg *= -1;
                                    cnt = 0;
                                }
                            }



                        }
                    }
                }
                if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
                {
                    push = true;
                    if (push)
                    {
                        GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, 400.0f, 0));
                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector3(200.0f, 0.0f, 0));
                        }
                        if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            GetComponent<Rigidbody2D>().AddForce(new Vector3(-200.0f, 0.0f, 0));
                        }
                        isGround = false;
                        isJump = true;
                       
                        if (isGround == true && move == 0)
                        {

                            isJump = false;
                            push = false;
                        }
                    }
                }
                    if (Input.GetKeyDown(KeyCode.G))
                    {
                        flg2 = 1;

                        if (flg2 == 1)
                        {
                            MainSpriteRenderer.sprite = HoldSprite9;
                            e.enabled = true;
                            flg2 = 0;
                        }


                    audioSource.clip = audioClip2;
                    audioSource.Play();


                }
                if (Input.GetKeyDown(KeyCode.F))
                {

                    Panel3.SetActive(true);


                }
                if (Input.GetKeyDown(KeyCode.J))
                {

                    Panel3.SetActive(false);

                }


            }
        }
    }   
     void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = true;
        isJump = false;
        if (collision.gameObject.tag=="zako1")
        {
            
            StartCoroutine("damage");
            life.LifeDown(MissCheck.attackPoint);
            MainSpriteRenderer.sprite = StandbySprite3;
        }
        if (collision.gameObject.tag == "miss" && maneg.flg == 0 && maneg.flg == 2)
        {
            gameOver = true;
            life.LifeDown(MissCheck.attackPoint+1000);
        }
        if (collision.gameObject.tag == "kisi"&&maneg.flg==1)
        {
            maneg.flg = 2;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
       
        if (collision.gameObject.tag == "bullet")
        {
            if (gameObject.layer == LayerMask.NameToLayer("player"))
            {
                StartCoroutine("damage");
                life.LifeDown(attackPoint);
            }
            //StartCoroutine("damage");
            MainSpriteRenderer.sprite = StandbySprite3;
          
        }
    }
    

/*private void OnTriggerEnter2D(Collider2D coll)
{
    MainSpriteRenderer.sprite = StandbySprite3;
    //GameOverGUI.SendMessage("Gameover");
    if (coll.gameObject.tag == "miss")
    {
        StartCoroutine("GameOver");

    }
}
IEnumerator GameOver()
{
    GameObject.Find("manegUI").SendMessage("GameOver");
    //GetComponent<Text>().text = "ゲームオーバー！";  //表示文字変更
    Destroy(gameObject);
    yield return new WaitForSeconds(1.0f);  //1秒経ったら進む
    SceneManager.LoadScene("scen1");           //シーン「01」をロード
}*/
IEnumerator damage()
        {
        //レイヤーをPlayerDamageに変更
        
        gameObject.layer = LayerMask.NameToLayer("playerDamage");
            //while文を10回ループ
            int count = 10;
            while (count > 0)
            {
                //透明にする
                renderer.material.color = new Color(1, 1, 1, 0);
                //0.05秒待つ
                yield return new WaitForSeconds(0.05f);
                //元に戻す
                renderer.material.color = new Color(1, 1, 1, 1);
                //0.05秒待つ
                yield return new WaitForSeconds(0.05f);
                count--;
            }
            //レイヤーをPlayerに戻す
            gameObject.layer = LayerMask.NameToLayer("player");
        }
   
}