using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class nextSC : MonoBehaviour
{
    public GameObject playter1,start2,box;
    public GameObject len,len1;
    public Animator anim;
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

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            StartCoroutine(st());

            
        }
    }

    IEnumerator st()
    {
        yield return new WaitForSeconds(6);
        playter1.transform.position = start2.transform.position;
        p.canmove = false;
        anim.SetBool("paint cans", false);
        box.SetActive(false);
        len.SetActive(true);
        len1.SetActive(false);
     
    }

}
