using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Story0 : MonoBehaviour
{
   // public GameObject[] story;

   // public bool[] s;

    public GameObject d,d1,d2;
    start p;
    AutoFlip p1;
    Book p2;
    // Start is called before the first frame update
    void Start()
    {
        p = d.GetComponent<start>();
        p1 = d1.GetComponent<AutoFlip>();
        p2 = d2.GetComponent<Book>();
        // s[0] = true;
    }

    // Update is called once per frame
    void Update()
    {
   
        if(p2.currentPage==2)
        {
            print("111");
        }
/*
        if (s[0])
        {
            story[0].SetActive(true);
     
        }
        else if(!s[0])
        {
            story[0].SetActive(false);
        }*/
  

       /* if (s[1])
        {
          
        }*/

      /*  if (Input.GetKeyDown(KeyCode.E))
        {

            p1.FlipRightPage();
        }*/

     
       // st();
    }

    public void st()
    {
      /*  if (s[0] == true && Input.GetKeyDown(KeyCode.E))
        {
             story[1].SetActive(true);
              s[0] = false;
              StartCoroutine(s1());
       

        }
        if (s[1] == true && Input.GetKeyDown(KeyCode.E))
        {
            s[1] = false;
            story[1].SetActive(false);
           

            p.anim.SetBool("start", true);
            p.StartCoroutine(p.an());
            p.StartCoroutine(p.cc());
            p.StartCoroutine(p.move());
        }*/


    
    }
  /*  IEnumerator s1()
    {
        yield return new WaitForSeconds(0.1f);
        s[1] = true;
    }*/
}
