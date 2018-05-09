using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimic4 : MonoBehaviour {
    int cnt = 0;
    int flg = 2;
    int Speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (flg == 2)
        {

            cnt++;
            transform.Translate(new Vector3((float)0.5, 0, 0) * Time.deltaTime * Speed);

            if (cnt == 200)
            {
                flg = 3;
                cnt = 0;
            }

        }
        else if (flg == 3)
        {
            cnt++;
            transform.Translate(new Vector3((float)-0.5, 0, 0) * Time.deltaTime * Speed);

            if (cnt == 200)
            {
                flg = 2;
                cnt = 0;
            }

        }
    }
}
