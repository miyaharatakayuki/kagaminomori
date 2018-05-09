using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class maneg : MonoBehaviour {
    GameObject player;
     public static int flg = 0;
     /*public GameObject player;       //プレイヤーゲームオブジェクトへの参照を格納する Public 変数
     public GameObject player2;

     private Vector3 offset;         //プレイヤーとカメラ間のオフセット距離を格納する Public 変数*/


    // Use this for initialization
    void Start () {
        this.player = GameObject.Find("player");
         flg = 0;
          //プレイヤーとカメラ間の距離を取得してそのオフセット値を計算し、格納します。
         // offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        this.player = GameObject.Find("player");
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
        /*transform.position -= new Vector3(0.5f, 0, 0);
        if (transform.position.x <= -16)
        {
            transform.position=new Vector3(-5,-0.2f,0);
        }*/
        //offset2 = transform.position - player2.transform.position;
        /*if (flg == 0||flg==1)
        {
            transform.position = player.transform.position + offset;
        }
        
        if (flg == 2)
        {

            transform.position = player2.transform.position + offset;
            transform.position = new Vector3(transform.position.x, transform.position.y-1.2f, transform.position.z);
        }
    }
    void LateUpdate()
    {

        //カメラの transform 位置をプレイヤーのものと等しく設定します。ただし、計算されたオフセット距離によるずれも加えます。
        //transform.position = player.transform.position + offset;
        //transform.position = player2.transform.position + offset2;
    }*/
    }
   
}
