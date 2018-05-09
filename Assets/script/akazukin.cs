using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akazukin : MonoBehaviour {
    int cnt = 0;
    int flg = 2;
    int Speed = 2;
    public GameObject GameClearGUI;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (flg == 2)
        {

            cnt++;
            transform.Translate(new Vector3(0f, 0.2f, 0) * Time.deltaTime * Speed);
            //transform.Rotate(0f, 0, 0.2f);
            if (cnt == 600)
            {
                flg = 3;
                cnt = 0;
            }

        }
        else if (flg == 3)
        {
            cnt++;
            transform.Translate(new Vector3(0f, -0.2f, 0) * Time.deltaTime * Speed);
            //transform.Rotate(0f, 0f, -0.1f);
            if (cnt == 600)
            {
                flg = 2;
                cnt = 0;
            }

        }
    }
    public void GameClear()
    {


        GameObject.Find("manegUI").SendMessage("GameClear");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (maneg.flg == 0 || maneg.flg == 2)
        {
            GameClearGUI.SendMessage("Gameclear");
            GameClear();
        }
    }
}
