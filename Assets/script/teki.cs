using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teki : MonoBehaviour {
    public float dir = -1.0f;    //方向：1.0fで右、-1.0fで左
    public float speed = 1.0f;
    public LayerMask checklayer;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<BoxCollider2D>().enabled = false;
        RaycastHit2D hit = Physics2D.Linecast(transform.position, transform.position + new Vector3(dir * 0.6f, 0, 0), checklayer);
        GetComponent<BoxCollider2D>().enabled = true;
        if (hit.collider != null)
        {
            dir = (dir == 1.0f) ? -1.0f : 1.0f;
        }
        if (dir > 0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            //dir = -0.1f;
        }
        else if (dir < -0.1f)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        transform.position += new Vector3(dir * speed * Time.deltaTime, 0, 0);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Destroy(this.gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);

    }
}
