using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sousa : MonoBehaviour {
    public GameObject Panel;
    public GameObject Panel2;
    public GameObject Panel3;
    public bool push = false;
    public bool push2 = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!push)
            {
                push = true;
                Panel.SetActive(true);
                Panel3.SetActive(false);
                push2 = false;
            }
            else if(push&&push2==false)
            {
                Panel.SetActive(false);
                Panel2.SetActive(true);
                push2 = true;

            }
            else 
            {
                Panel2.SetActive(false);
                Panel3.SetActive(true);
                push = false;

            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Panel.SetActive(false);
            Panel2.SetActive(false);
            Panel3.SetActive(false);


        }
    }
}
