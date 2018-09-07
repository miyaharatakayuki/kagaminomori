using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boss : MonoBehaviour {
    public GameObject GameClearGUI;
    float span = 1.0f;
    float delta = 0;
    public GameObject archr;
    int frame;
    public GameObject bullet_teki; // 弾のオブジェクト
    //public player Player;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    private AudioSource audioSource;
    // Use this for initialization
   
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(archr) as GameObject;
            int px = Random.Range(200, 222);
            int py = Random.Range(0, 4);
            go.transform.position = new Vector3(px, py, 0);
        }
        
    }

    // Update is called once per frame
    void Update () {
        if (transform.position.x >= 170)
        {
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(archr) as GameObject;
                int px = Random.Range(200, 222);
                int py = Random.Range(0, 5);
                go.transform.position = new Vector3(px, py, 0);
                audioSource.Play();
                Destroy(gameObject);
            }
            //弾の生成
            frame++;
            if (frame == 10)
            {
                Instantiate(bullet_teki, new Vector2(transform.position.x - 0.1f, transform.position.y), Quaternion.identity); // 敵の位置に弾を生成します
                audioSource.clip = audioClip2;
                audioSource.Play();
                frame = 0;
            }
        }



    }
    public void GameClear()
    {
        

        GameObject.Find("manegUI").SendMessage("GameClear");
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        GameClearGUI.SendMessage("Gameclear");
        GameClear();

    }*/
   
}
