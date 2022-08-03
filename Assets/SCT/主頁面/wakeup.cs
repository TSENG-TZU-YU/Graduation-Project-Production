using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wakeup : MonoBehaviour
{
    public Animator anim;

    public GameObject len, len1;
    public GameObject can;

    public GameObject d;
    player p;


    // Start is called before the first frame update
    void Start()
    {
        p = d.GetComponent<player>();


    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator cc()
    {
        yield return new WaitForSeconds(3f);
        can.SetActive(false);

    }

    IEnumerator move()
    {
        yield return new WaitForSeconds(3.617f);
        p.canmove = true;
        p.down = false;
        // can1.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            StartCoroutine(an1());
            p.canmove = false;

        }
      
    }



    IEnumerator an()
    {
        yield return new WaitForSeconds(3f);
       // anim.SetBool("start", false);
        anim.SetBool("startback",false);
        len1.SetActive(true);
        len.SetActive(false);

        GetComponent<BoxCollider2D>().enabled = false;
    }
    IEnumerator an1()
    {
        yield return new WaitForSeconds(5.4f);
        anim.SetBool("startback", true);
        StartCoroutine(cc());
        StartCoroutine(move());
        StartCoroutine(an());
    }
         
}
