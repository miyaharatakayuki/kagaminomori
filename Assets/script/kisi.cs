using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kisi : MonoBehaviour {
    public static Vector3 iti;
    // Use this for initialization
    void Start () {
        iti = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        iti = this.transform.position;
        if (maneg.flg == 2)
        {
            Destroy(gameObject);
        }
    }
   
      

    
}
