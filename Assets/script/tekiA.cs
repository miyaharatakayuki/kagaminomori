using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tekiA : MonoBehaviour {
    public float m_moveSpeed = 2f;
    // 円の半径
    public float m_radius = 2f;
    GameObject player;
    // Use this for initialization
    void Start () {

        this.player = GameObject.Find("player");
    }

// Update is called once per frame
void Update () {
        // 円移動
        //MoveToCircle();
        //８の字移動
        if (maneg.flg == 1)
        {
            // MoveToFigureOfEight();

            transform.Translate(-0.1f, 0, 0);
            if (transform.position.x < -1.0f)
            {
                Destroy(gameObject);
            }
            Vector2 p1 = transform.position;
            Vector2 p2 = player.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.4f;
            float r2 = 0.5f;
            if (d < r1 + r2)
            {
               
                GameObject.Find("manegUI").SendMessage("GameOver");
                Destroy(player);
               

            }
        }
        }
    void MoveToCircle()
    {
        // 経過時間の取得
        float time = Time.time;
        // 円運動の座標演算
        float x = Mathf.Sin(time);
        float y = 0.0f;
        float z = Mathf.Cos(time);
        // オブジェクトに座標を代入
        transform.position = new Vector3(x, y, z);
    }
    // ８の字移動-----------------------------------------------------------------------
    void MoveToFigureOfEight()
    {

        // 経過時間の取得
        float time = Time.time;
        // ８の字移動の座標演算
        float x = Mathf.Cos(time) * 2;
        float y = 0.0f;
        float z = Mathf.Sin(time) * 2;
        // オブジェクトに座標を代入
        transform.position = new Vector3(x, y, z);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Player"&&maneg.flg==1)
        {
            StartCoroutine(GameOver2());
        }

    }
    IEnumerator GameOver2()
    {
        //GetComponent<Text>().text = "ゲームオーバー！";  //表示文字変更

        yield return new WaitForSeconds(1.0f);  //1秒経ったら進む
        SceneManager.LoadScene("scen1");           //シーン「01」をロード
    }
}
