using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paint : MonoBehaviour
{
    public Color[] colorList;
    public Color curColor;
    public int colorCount;

    public GameObject s1, s2,s3;
    public bool sc1,sc2;

    //上色
    public SpriteRenderer[] n;
    public SpriteRenderer[] n1;
    public SpriteRenderer[] n2;
    public GameObject[] r1;
    public GameObject[] b1;
    public GameObject[] pen;
    public GameObject colorcan0, colorcan1, colorcan2;

    public GameObject d, d1, end,end1, end2,endmovie, pa;
    PaintCans p;
    player p1;
    public bool pencolor,win1,win2;

    public GameObject box,box1,map,map2;
    public AudioSource music,waterfull;


    // bool n0, n1, n2, n3, n4, n5,n6,n7,n8,n9;

    // Start is called before the first frame update
    void Start()
    {
        curColor = colorList[6]; //初始顏色
        p = d.GetComponent<PaintCans>();
        p1 = d1.GetComponent<player>();
        pencolor = true;
    }

    // Update is called once per frame
    void Update()
    {
      

        curColor = colorList[colorCount];

        var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray, -Vector2.up);

        if (pencolor)
        {
            if (Input.GetButton("Fire1"))
            {
                if (hit.collider != null)
                {
                    SpriteRenderer sp = hit.collider.gameObject.GetComponent<SpriteRenderer>();
                    //  Debug.Log(hit.transform.name);


                    sp.color = curColor;



                }
            }

        }

  

        if (win1)
        {
            p.pen.SetActive(false);
            end.SetActive(true);
            pa.SetActive(false);
            p1.canmove = false;
            pencolor = false;
            colorcan0.SetActive(false);
            box.SetActive(true);
            StartCoroutine(st2());
        }
        if(win2)
        {
            p.pen.SetActive(false);
            end1.SetActive(true);
            pa.SetActive(false);
            p1.canmove = false;
            pencolor = false;
            colorcan1.SetActive(false);
            box1.SetActive(true);
            StartCoroutine(st3());
        }


        color();
        win();

        if (curColor == colorList[0])
        {
            pen[0].SetActive(true);
            pen[4].SetActive(false);
            pen[1].SetActive(false);
            pen[2].SetActive(false);
            pen[3].SetActive(false);
            pen[5].SetActive(false);
        }
        if (curColor == colorList[4])
        {

            pen[4].SetActive(true);
            pen[0].SetActive(false);
            pen[1].SetActive(false);
            pen[2].SetActive(false);
            pen[3].SetActive(false);
            pen[5].SetActive(false);
        }
        if (curColor == colorList[1])
        {

            pen[4].SetActive(false);
            pen[0].SetActive(false);
            pen[1].SetActive(true);
            pen[2].SetActive(false);
            pen[3].SetActive(false);
            pen[5].SetActive(false);
        }
        if (curColor == colorList[2])
        {

            pen[4].SetActive(false);
            pen[0].SetActive(false);
            pen[1].SetActive(false);
            pen[2].SetActive(true);
            pen[3].SetActive(false);
            pen[5].SetActive(false);
        }
        if (curColor == colorList[3])
        {

            pen[4].SetActive(false);
            pen[0].SetActive(false);
            pen[1].SetActive(false);
            pen[2].SetActive(false);
            pen[3].SetActive(true);
            pen[5].SetActive(false);
        }
        if (curColor == colorList[5])
        {

            pen[4].SetActive(false);
            pen[0].SetActive(false);
            pen[1].SetActive(false);
            pen[2].SetActive(false);
            pen[3].SetActive(false);
            pen[5].SetActive(true);
        }
        if (curColor == colorList[6])
        {
            pen[0].SetActive(false);
            pen[4].SetActive(false);
        }





    }

    public void paint(int colorCode)
    {
        colorCount = colorCode;
    }

    public void win()
    {
        if(sc1)
        {
            if (n[0].color == colorList[0] && n[1].color == colorList[4] && n[2].color == colorList[4] && n[3].color == colorList[0] && n[4].color == colorList[0] &&
         n[5].color == colorList[4] && n[6].color == colorList[4] && n[7].color == colorList[0] && n[8].color == colorList[0] && n[9].color == colorList[4])
            {
               // print("win");

                win1 = true;
     


            }
        }
     
        if(sc2)
        {
            if (n1[0].color == colorList[0] && n1[1].color == colorList[2] && n1[2].color == colorList[3] && n1[3].color == colorList[1] && n1[4].color == colorList[2] &&
      n1[5].color == colorList[0])
            {
                // print("win");

                win2 = true;


            }
        }
    

        if(n2[0].color == colorList[0] && n2[1].color == colorList[1] && n2[2].color == colorList[2] && n2[3].color == colorList[3] && n2[4].color == colorList[4] &&
         n2[5].color == colorList[5] && n2[6].color == colorList[1] && n2[7].color == colorList[2] && n2[8].color == colorList[3] && n2[9].color == colorList[4] &&
         n2[10].color == colorList[5]  )
        {
            print("win");
            p.pen.SetActive(false);
           // end2.SetActive(true);
            pa.SetActive(false);
            p1.canmove = false;
            pencolor = false;
            colorcan1.SetActive(false);
            end2.SetActive(true);
            StartCoroutine(movie());
            music.volume -= 0.005f;
            if (waterfull.volume >= 0)
            {
                waterfull.volume -= 0.001f;
            }

        }


    }


    public void color()
    {
        if (n[0].color == colorList[0])
        {

            r1[0].SetActive(true);
            b1[0].SetActive(false);
        }
        if (n[0].color == colorList[4])
        {

            b1[0].SetActive(true);
            r1[0].SetActive(false);
        }
        if (n[1].color == colorList[0])
        {
            b1[1].SetActive(true);
            r1[1].SetActive(false);


        }
        if (n[1].color == colorList[4])
        {
            r1[1].SetActive(true);
            b1[1].SetActive(false);

        }
        if (n[2].color == colorList[0])
        {
            b1[2].SetActive(true);
            r1[2].SetActive(false);


        }
        if (n[2].color == colorList[4])
        {
            r1[2].SetActive(true);
            b1[2].SetActive(false);

        }
        if (n[3].color == colorList[0])
        {
            b1[3].SetActive(true);
            r1[3].SetActive(false);


        }
        if (n[3].color == colorList[4])
        {
            r1[3].SetActive(true);
            b1[3].SetActive(false);

        }
        if (n[4].color == colorList[0])
        {
            b1[4].SetActive(true);
            r1[4].SetActive(false);


        }
        if (n[4].color == colorList[4])
        {
            r1[4].SetActive(true);
            b1[4].SetActive(false);

        }
        if (n[5].color == colorList[0])
        {
            b1[5].SetActive(true);
            r1[5].SetActive(false);


        }
        if (n[5].color == colorList[4])
        {
            r1[5].SetActive(true);
            b1[5].SetActive(false);

        }
        if (n[6].color == colorList[0])
        {
            b1[6].SetActive(true);
            r1[6].SetActive(false);


        }
        if (n[6].color == colorList[4])
        {
            r1[6].SetActive(true);
            b1[6].SetActive(false);

        }
        if (n[7].color == colorList[0])
        {
            b1[7].SetActive(true);
            r1[7].SetActive(false);


        }
        if (n[7].color == colorList[4])
        {
            r1[7].SetActive(true);
            b1[7].SetActive(false);

        }
        if (n[8].color == colorList[0])
        {
            b1[8].SetActive(true);
            r1[8].SetActive(false);


        }
        if (n[8].color == colorList[4])
        {
            r1[8].SetActive(true);
            b1[8].SetActive(false);

        }
        if (n[8].color == colorList[0])
        {
            b1[8].SetActive(true);
            r1[8].SetActive(false);


        }
        if (n[8].color == colorList[4])
        {
            r1[8].SetActive(true);
            b1[8].SetActive(false);

        }
        if (n[9].color == colorList[0])
        {
            b1[9].SetActive(true);
            r1[9].SetActive(false);


        }
        if (n[9].color == colorList[4])
        {
            r1[9].SetActive(true);
            b1[9].SetActive(false);

        }
    }

    IEnumerator st2()
    {
        yield return new WaitForSeconds(6f);
        p.pen.SetActive(true);
        pa.SetActive(true);
      //  p1.canmove = true;
        s1.SetActive(false);
        s2.SetActive(true);
        pencolor = true;
        sc1 = false;
        sc2 = true;
        // Destroy(end);
        StartCoroutine(E());
        map.SetActive(true);
        win1 = false;
        GameObject.Find("Player").GetComponent<waterfull>().enabled = true;
  

        StartCoroutine(E1());
    }
    IEnumerator st3()
    {
        yield return new WaitForSeconds(6f);
        p.pen.SetActive(true);
      //  pa.SetActive(true);
       // p1.canmove = true;
        s2.SetActive(false);
        s3.SetActive(true);
        pencolor = true;
        sc2 = false;
      
        map2.SetActive(true);
        win2 = false;
        StartCoroutine(E3());
        StartCoroutine(E2());
        GameObject.Find("Player").GetComponent<waterfull>().enabled = false;
    }

    IEnumerator E()
    {
        yield return new WaitForSeconds(6f);
        map.SetActive(false);
        colorcan1.SetActive(true);
    }

    IEnumerator E1()
    {
        yield return new WaitForSeconds(0.5f);
       
        end.SetActive(false);
    }
    IEnumerator E2()
    {
        yield return new WaitForSeconds(0.5f);

        end1.SetActive(false);
    }
    IEnumerator E3()
    {
        yield return new WaitForSeconds(6f);
        map2.SetActive(false);
        colorcan2.SetActive(true);
        if(waterfull.volume<=0.08)
        {
            waterfull.volume += 0.001f;
        }
      
    }

    IEnumerator movie()
    {
        yield return new WaitForSeconds(2f);
        endmovie.SetActive(true);
        StartCoroutine(movie1());
      
    }

    IEnumerator movie1()
    {
        yield return new WaitForSeconds(0.8f);
        end2.SetActive(false);
    }
}



/* if(n[0].color == colorList[0] || n[0].color == colorList[4])
 {
     n0 = true;
 }
 if(n[1].color == colorList[4] || n[1].color == colorList[0])
 {
     n1 = true;
 }
 if (n[2].color == colorList[4] || n[2].color == colorList[0])
 {
     n2 = true;
 }
 if (n[3].color == colorList[0] || n[3].color == colorList[4])
 {
     n3 = true;
 }
 if (n[4].color == colorList[0] || n[4].color == colorList[4] )
 {
     n4 = true;
 }
 if (n[5].color == colorList[4] || n[5].color == colorList[0])
 {
     n5 = true;
 }
 if (n[6].color == colorList[4] || n[6].color == colorList[0])
 {
     n6 = true;
 }
 if (n[7].color == colorList[0] || n[7].color == colorList[4])
 {
     n7 = true;
 }
 if (n[8].color == colorList[0] || n[8].color == colorList[4])
 {
     n8 = true;
 }
 if (n[9].color == colorList[4] || n[9].color == colorList[0])
 {
     n9 = true;
 }

 if(n0 == true && n1 ==true && n2 == true && n3 == true && n4 == true && n5 == true && n6 == true && n7 == true && n8 == true && n9 == true )
 {
     print("lose");
 }*/

