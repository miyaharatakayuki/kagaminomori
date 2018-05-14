using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tekiB : MonoBehaviour {
    int frame2 = 0;
    float span = 1.0f;
    float delta = 0;
    public GameObject bullet_teki; // 弾のオブジェクト
    public AudioClip audioClip1;
    int flg = 0;
    private AudioSource audioSource;
    public GameObject archr;
    public player Player;
    void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(archr) as GameObject;
            int px = Random.Range(147, 150);
            int py = Random.Range(0, 0);
            go.transform.position = new Vector3(px, py, 0);

          
        }
    }
	
	// Update is called once per frame
	void Update () {
        //弾の生成
        if (Player.transform.position.x >= 120)
        {
            frame2++;
            this.delta += Time.deltaTime;
            if (this.delta > this.span)
            {
                this.delta = 0;
                GameObject go = Instantiate(archr) as GameObject;
                int px = Random.Range(147, 150);
                int py = Random.Range(0, 0);
                go.transform.position = new Vector3(px, py, 0);

                Destroy(gameObject);
            }

            if (frame2 == 50)
            {
                Instantiate(bullet_teki, new Vector2(transform.position.x - 0.1f, transform.position.y), Quaternion.identity); // 敵の位置に弾を生成します
                audioSource.clip = audioClip1;
                audioSource.Play();
                frame2 = 0;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
       

    }
}
