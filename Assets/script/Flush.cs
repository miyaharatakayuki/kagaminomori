﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Flush : MonoBehaviour {
    Image img;
	// Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        img.color = Color.clear;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            this.img.color = new Color(0.5f, 0f, 0f, 0.5f);
        }
        else
        {
            this.img.color = Color.Lerp(this.img.color, Color.clear, Time.deltaTime);
        }

    }
}
