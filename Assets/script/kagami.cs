using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kagami : MonoBehaviour {
    //public GameObject player2;
    // public GameObject player;
    // Use this for initialization
    //public bool efe;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    private AudioSource audioSource;
    public Animator efe;
    void Start () {
        // player2 = GameObject.Find("gosuto");
        //efe = false;
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip1;
    }
	
	// Update is called once per frame
	void Update () {
        /*if (efe.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.9f)
        {
            Destroy(this.gameObject);
        }*/
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (maneg.flg == 0)
        {
          
            //efe = true;
            maneg.flg = 1;
            audioSource.Play();
            player.idle = true;
        }
        else if (maneg.flg == 1)
        {
            //efe = true;
            player.meisuu = 11;
            audioSource.clip = audioClip1;
            audioSource.Play();
            maneg.flg = 0;
           
        }
        if (maneg.flg == 2)
        {
            //efe = true;
            audioSource.clip = audioClip1;
            audioSource.Play();
            maneg.flg = 0;

        }


        /*if (maneg.flg == 1)
        {
            //Instantiate(player2, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
        }
        if (maneg.flg == 2)
        {
            maneg.flg = 0;
            if (maneg.flg == 0)
            {
                Instantiate(player, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.identity);
            }
        }*/
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        //Destroy(goustgene.ghostPrefab);
    }


}
