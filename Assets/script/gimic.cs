using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gimic : MonoBehaviour {
    int cnt;
    int flg = 1;
    public player Player;
    public GameObject GameOverGUI;
    // Use this for initialization
    void Start () {
        cnt = 0;
    }
	
	// Update is called once per frame
	void Update () {
        cnt++;
        //transform.Rotate(new Vector3(0, 0, 5));
        if (flg == 1)
        {
            transform.position += (new Vector3(0f, 0.2f, 0));
            if (cnt ==30)
            {
                flg = 0;
                cnt = 0;
            }
        }
        else if(flg==0)
        {
            transform.position += (new Vector3(0f, -0.2f, 0));
            if (cnt == 30)
            {
                flg = 1;
                cnt = 0;
            }

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.gameObject.tag == "Player" && maneg.flg == 0&&transform.position.y<0f)
        {
          
            transform.position = new Vector3(171.54f, -2.4f, 0);
            flg = -1;
            StartCoroutine("GameOver");
        }

    }
    IEnumerator GameOver()
    {
        GameOverGUI.SendMessage("Gameover");
        Destroy(Player);
        yield return new WaitForSeconds(1.0f);  //1秒経ったら進む
        SceneManager.LoadScene("scen1");           //シーン「01」をロード
    }
}
