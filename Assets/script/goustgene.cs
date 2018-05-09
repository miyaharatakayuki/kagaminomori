using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goustgene : MonoBehaviour {
    public  GameObject ghostPrefab;
    float span = 2.0f;
    float delta = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ghostPrefab) as GameObject;
            int px = Random.Range(150, 180);
            int py = Random.Range(0, 9);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
