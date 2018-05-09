using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public int attackPoint = 100;
    
    int RL_flg = 0;
    // Use this for initialization
    void Start () {
        if (transform.position.x > 0)
        {
            RL_flg = 1;
        }
        else
        {
            RL_flg = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.Translate(-0.3f, -0.1f, 0);    //0.3ずつ下に飛ぶ
        if (RL_flg == 1)
        {
            transform.Translate(-0.02f, 0, 0);    //0.3ずつ下に飛ぶ
        }
        else
        {
            transform.Translate(0.02f, 0, 0);    //0.3ずつ下に飛ぶ
        }
        if (transform.position.y < -8)
        {
            Destroy(this.gameObject);       //弾を消す
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MissCheck.life.LifeDown(attackPoint);
        }
    }
}
