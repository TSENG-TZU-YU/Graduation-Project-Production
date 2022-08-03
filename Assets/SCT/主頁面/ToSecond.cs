using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToSecond : MonoBehaviour
{
    public GameObject sc1,sc2,sc3,start,start1;
    public GameObject playter1, start2, start3, can2, can3;
    public Animator anim;
    public GameObject  colorstar2, colorstar3, colorred, colorblue, coloryellow, colorgreen, coloro;
    public GameObject colorCan, colorCan3;
    public GameObject camera,camera1;
    public GameObject d;
    player p;
    public AudioSource  waterfull;


    // Start is called before the first frame update
    void Start()
    {
        p = d.GetComponent<player>();
      
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.O))
        {
            camera1.SetActive(true);
            camera.SetActive(false);
            sc1.SetActive(false);
            sc3.SetActive(false);
            sc2.SetActive(true);
            start.SetActive(false);
            start1.SetActive(false);
            anim.SetBool("start", true);
            playter1.transform.position = start2.transform.position;
            colorred.SetActive(true);
            colorblue.SetActive(true);
            colorstar2.SetActive(true);
            StartCoroutine(can());
            can2.GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Player").GetComponent<waterfull>().enabled = true;
        }
        if (Input.GetKey(KeyCode.P))
        {
            camera1.SetActive(true);
            camera.SetActive(false);
            sc1.SetActive(false);
            sc3.SetActive(true);
            sc2.SetActive(false);
            start.SetActive(false);
            start1.SetActive(false);
            anim.SetBool("start", true);
            playter1.transform.position = start3.transform.position;
            colorred.SetActive(true);
            colorblue.SetActive(true);
            colorgreen.SetActive(true);
            coloryellow.SetActive(true);
            coloro.SetActive(true);
            colorstar2.SetActive(false);
            colorstar3.SetActive(true);
            StartCoroutine(can1());
            can3.GetComponent<BoxCollider2D>().enabled = false;
            if (waterfull.volume <= 0.08)
            {
                waterfull.volume += 0.001f;
            }
    
        }

    }

    IEnumerator can()
    {
        yield return new WaitForSeconds(3f);
        colorCan.SetActive(false);
        camera.SetActive(true);
        camera1.SetActive(false);
        p.canmove = true;
        anim.SetBool("start", false);

    }
    IEnumerator can1()
    {
        yield return new WaitForSeconds(3f);
        colorCan3.SetActive(false);
        camera.SetActive(true);
        camera1.SetActive(false);
        p.canmove = true;
        anim.SetBool("start", false);

    }
}
