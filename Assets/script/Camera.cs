using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    // 変数の定義
    private Transform target;
   
    private Transform target2;
    // シーン開始時に一度だけ呼ばれる関数
    // Use this for initialization
    void Start () {
        // 変数にPlayerオブジェクトのtransformコンポーネントを代入
        target = GameObject.Find("player").transform;
        //target2 = GameObject.Find("ghost").transform;
    }
	
	// Update is called once per frame
	void Update () {
        // カメラのx座標をPlayerオブジェクトのx座標から取得y座標とz座標は現在の状態を維持
        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
       // transform.position = new Vector3(target2.position.x, transform.position.y, transform.position.z);
    }
  
}
