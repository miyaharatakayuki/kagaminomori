using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MissCheckU : MonoBehaviour {
    //int i = 3;
    public player Player;
    public GameObject GameOverGUI;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D coll)
    {

        //GameOverGUI.SendMessage("Gameover");
        if (coll.gameObject.tag == "Player")
        {
            StartCoroutine("GameOver");
            
        }
    }
    IEnumerator GameOver()
    {
        GameObject.Find("manegUI").SendMessage("GameOver");
        GameOverGUI.SendMessage("Gameover");
        //GetComponent<Text>().text = "ゲームオーバー！";  //表示文字変更
        Destroy(Player);
        yield return new WaitForSeconds(1.0f);  //1秒経ったら進む
        SceneManager.LoadScene("scen1");           //シーン「01」をロード
    }
}

