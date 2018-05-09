using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigit2 : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
/// <summary>

/// Rigidbody2D 型の拡張メソッドを管理するクラス

/// </summary>

public static class Rigidbody2DExtension
{



    /// <summary>

    /// 一時停止

    /// </summary>

    public static void Pause(this Rigidbody2D rigidbody2D, GameObject gameObject)
    {

        gameObject.AddComponent<rigid>().Set(rigidbody2D);

        rigidbody2D.isKinematic = true;

    }



    /// <summary>

    /// 再開

    /// </summary>

    public static void Resume(this Rigidbody2D rigidbody2D, GameObject gameObject)
    {

        if (gameObject.GetComponent<rigid>() == null)
        {

            return;

        }



        rigidbody2D.velocity = gameObject.GetComponent<rigid>().Velocity;

        rigidbody2D.angularVelocity = gameObject.GetComponent<rigid>().AngularVelocity;

        rigidbody2D.isKinematic = false;



        GameObject.Destroy(gameObject.GetComponent<rigid>());

    }
}