using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour {
    RectTransform rt;
    public GameObject player;
    public Text gameOverText;
    public static bool gameOver = false;
    public GameObject GameOverGUI;
    // Use this for initialization
    void Start () {
        rt = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rt.sizeDelta.y <= 0)
        {
            GameOver();
        }
	}
    public void LifeDown(int ap)
    {
        rt.sizeDelta -= new Vector2(0, ap);
    }
    public void GameOver()
    {
        gameOver = true;
        Destroy(player);
        GameOverGUI.SendMessage("Gameover");
        GameObject.Find("manegUI").SendMessage("GameOver");
    }
}
