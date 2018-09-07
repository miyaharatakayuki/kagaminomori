using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = GameObject.Find("player").transform.position.x;
        float y = transform.position.y;
        transform.position = new Vector2(x, y);
    }
}
