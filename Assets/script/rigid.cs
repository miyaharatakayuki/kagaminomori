using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigid : MonoBehaviour {
    //一時停止時の速度

    private float _angularVelocity;

    private Vector2 _velocity;



    public float AngularVelocity
    {

        get { return _angularVelocity; }

    }

    public Vector2 Velocity
    {

        get { return _velocity; }

    }



    /// <summary>

    /// Rigidbody2Dを入力して速度を設定する

    /// </summary>

    public void Set(Rigidbody2D rigidbody2D)
    {

        _angularVelocity = rigidbody2D.angularVelocity;

        _velocity = rigidbody2D.velocity;

    }







    
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    

}
