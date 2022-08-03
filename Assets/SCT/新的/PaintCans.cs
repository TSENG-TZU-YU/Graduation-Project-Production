using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCans : MonoBehaviour
{

    public GameObject moveplaneA;
    public Transform EndPointA;
    public float MoveSpeed;
    public Vector2 targetA;
    public bool go,change;
    public Animator anim;
    public GameObject cans,pan;

    public GameObject C;   //新顏料罐

    public GameObject d;
    player p;


 

    //mouse
    public RectTransform canvas;

    public GameObject pen;

    //時間計算
    public float timer = 0;
    int timer_i = 0;
    int second = 0;


    // Start is called before the first frame update
    void Start()
    {
        change = false;

        p = d.GetComponent<player>();
  



    }

    // Update is called once per frame
    void Update()
    {

        if (go==true)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = EndPointA.position;
     
     
            anim.SetBool("paint cans", true);
            StartCoroutine(ch());
            p.down = true;
            pan.SetActive(true);
            Cursor.visible = false;

            timer += Time.deltaTime;
            timer_i = (int)timer;
            time();
            if (second>120)
            {
                print("提示");
            }
      
            
         
        }
        
        if(go==false)
        {
            anim.SetBool("paint cans", false);

            StartCoroutine(ch1());
            p.down = false;
            pan.SetActive(false);




        }



        //將滑鼠座標轉換至UI座標的方法
        Vector2 Pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, new Vector2(Input.mousePosition.x+ 175, Input.mousePosition.y + 355), null, out Pos);
       
        //UI跟隨滑鼠
        pen.transform.localPosition = Pos;

        if (p.canmove)
        {
            if (change && Input.GetKeyDown(KeyCode.Space))
            {
                go = false;
            }
        }
     

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        C.SetActive(false);

        if(p.canmove)
        {
            if (collision.tag == "Player" && !change)
            {


                if (Input.GetKey(KeyCode.Space))
                {
                    go = true;
                   
                }


            }
        }



      

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        C.SetActive(true);
    }

    IEnumerator ch()
    {
        yield return new WaitForSeconds(0.1f);
        change = true;
        cans.SetActive(true);

    }
    IEnumerator ch1()
    {
        yield return new WaitForSeconds(0.1f);
        change = false;
        cans.SetActive(false);

    }

  void time()
    {
        second = timer_i % 60;
    }
}
