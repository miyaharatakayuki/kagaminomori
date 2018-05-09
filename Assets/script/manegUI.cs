using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class manegUI : MonoBehaviour {
    public Text TEXT;
    // Use this for initialization
    void Start () {
        if (Life.gameOver == true)
        {
            StartCoroutine("GameOver");
        }
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    IEnumerator GameClear()
    {
        //GetComponent<Text>().text = "クリア！！";    //表示文字を変更
        yield return new WaitForSeconds(3.0f);  //3秒経ったら進む
        SceneManager.LoadScene("title");           //シーン「00」をロード
    }
    IEnumerator GameOver()
    {
        //GetComponent<Text>().text = "ゲームオーバー！";  //表示文字変更
      
        yield return new WaitForSeconds(3.0f);  //3秒経ったら進む
        SceneManager.LoadScene("scen1");           //シーン「01」をロード
        Life.gameOver = false;
    }
}
