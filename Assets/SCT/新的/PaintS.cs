using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintS : MonoBehaviour
{

    public Color[] colorList;
    public Color curColor;
    public int colorCount;

    //第二關
    public SpriteRenderer[] n;

    public GameObject[] pen;

    public GameObject d, d1, end, pa;
    PaintCans p;
    player p1;
    public bool pencolor;

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

       /* var ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
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

                    if (p.go == false)
                    {
                        curColor = colorList[6];
                        sp.color = curColor;
                    }


                }
            }

        }*/




        win();

     /*   if (curColor == colorList[0])
        {
            pen[0].SetActive(true);
            pen[4].SetActive(false);
        }
        if (curColor == colorList[4])
        {

            pen[4].SetActive(true);
            pen[0].SetActive(false);
        }
        if (curColor == colorList[6])
        {
            pen[0].SetActive(false);
            pen[4].SetActive(false);
        }*/

    }

    public void paint(int colorCode)
    {
        colorCount = colorCode;
    }

    public void win()
    {
        if (n[0].color == colorList[0] && n[1].color == colorList[3] && n[2].color == colorList[3] && n[3].color == colorList[1] && n[4].color == colorList[0] &&
            n[5].color == colorList[2] )
        {
            print("win");
          

        }



    }
 
    
}
