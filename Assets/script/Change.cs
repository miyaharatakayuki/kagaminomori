using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {
    //　現在どのキャラクターを操作しているか
    private int nowChara;

    //　操作可能なゲームキャラクター
    [SerializeField]
    private List<GameObject> charaLists;

    public GameObject gameObject;
    public GameObject gameObject2;
    // Use this for initialization
    void Start () {
        //　最初の操作キャラクターを0番目のキャラクターにする為、キャラクターの総数をnowCharaに設定し最初のキャラクターが設定されるようにする
        nowChara = charaLists.Count;
        ChangeCharacter(nowChara);
        gameObject2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        /*//　デバック_Qキーが押されたら操作キャラクターを次のキャラクターに変更する
        if (Input.GetKeyDown("q"))
        {
            ChangeCharacter(nowChara);
        }*/


    }
    //　操作キャラクター変更メソッド
    void ChangeCharacter(int tempNowChara)
    {
        bool changeflg = false;
        //　次の操作キャラクターを指定
        int nextChara = tempNowChara + 1;
        //　次の操作キャラクターがいない時は最初のキャラクターに設定
        if (nextChara >= charaLists.Count)
        {
            nextChara = 0;
        }
        //　次の操作キャラクターだったら動く機能を有効にし、それ以外は無効にする
        for (var i = 0; i < charaLists.Count; i++)
        {

            if (i == nextChara)
            {
                changeflg = true;
                gameObject.SetActive(false);
                gameObject2.SetActive(true);
            }
            else
            {
                changeflg = false;
                gameObject.SetActive(true);
                gameObject2.SetActive(false);
            }
        }
        //　次の操作キャラクターを現在操作しているキャラクターに設定して終了
        nowChara = nextChara;
    }
    void OnTriggerStay2D(Collider2D other)
    {
        ChangeCharacter(nowChara);

    }




}
