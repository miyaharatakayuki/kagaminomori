using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class tekihp : MonoBehaviour {
    public GameObject archr;
    RectTransform rt;
   // public GameObject GameClearGUI;
    // Use this for initialization
    void Start () {
        rt = GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rt.sizeDelta.y <= 0)
        {
            GameClear();
        }
    }
    public void LifeDown(int ap)
    {
        rt.sizeDelta -= new Vector2(0, ap);
    }
    public void GameClear()
    {
      
        Destroy(gameObject);
      
    }
}
