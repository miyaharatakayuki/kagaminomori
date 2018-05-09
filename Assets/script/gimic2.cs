using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimic2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (maneg.flg == 1)
        {
            //GetComponent<BoxCollider2D>().enabled = false;  //コライダーを無効化
        }
    }
}
