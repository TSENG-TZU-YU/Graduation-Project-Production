using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMove : MonoBehaviour
{
 
    public Animator anim,anim1,anim2,anim3;
    public Animator op;
    public GameObject eye,eyesay;

    public GameObject E;

    public GameObject open;
    public GameObject open2;
    public GameObject open3;
    public GameObject open4;
    public GameObject close;
    public GameObject close2;
    public GameObject close3;
    public GameObject close4;

    public bool win=false;
    public bool TireRodA;
    public bool TireRodB;
    public bool TireRodC;
    public bool TireRodD;

    public bool push;
    public bool push1;
    public bool push2;
    public bool push3;


    // Start is called before the first frame update
    void Start()
    {
        TireRodA = false;
        TireRodB = false;
        TireRodC = false;
        TireRodD = false;

        push = false;
        push1 = false;
        push2 = false;
        push3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(win==false)
        {
            if (TireRodA == true)
            {
                anim.SetBool("redstart", true);
                anim.SetBool("redup", true);


            }
            else if (TireRodA == false)
            {
                anim.SetBool("redup", false);


            }

            if (TireRodB == true)
            {
                anim1.SetBool("bluestart", true);
                anim1.SetBool("blueup", true);
            }
            else if (TireRodB == false)
            {
                anim1.SetBool("blueup", false);
            }

            if (TireRodC == true)
            {
                anim2.SetBool("ystart", true);
                anim2.SetBool("yup", true);
            }
            else if (TireRodC == false)
            {
                anim2.SetBool("yup", false);
            }

            if (TireRodD == true)
            {
                anim3.SetBool("gstart", true);
                anim3.SetBool("gup", true);
            }
            else if (TireRodD == false)
            {
                anim3.SetBool("gup", false);
            }


        }


        //J通關
        if (TireRodA==true && TireRodB==true && TireRodC==true && TireRodD==true)  
        {
    
            op.SetBool("open", true);
            win = true;
            eye.SetActive(false);
            eyesay.SetActive(true);


        }
     


    }

    private void OnTriggerStay2D(Collider2D collision)
    {


     /*   if (collision.tag == "BOX4")
        {
            E.SetActive(true);
        }*/


        if (Input.GetKeyDown(KeyCode.E) && collision.tag== "BOX1" && push == false)
        {
            TireRodB = true;
            TireRodD = true;
            open.SetActive(true);
            close.SetActive(false);
            push = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX1" && push == true)
        {
            TireRodB = false;
            TireRodD = false;
            open.SetActive(false);
            close.SetActive(true);
            push = false;

        }

        if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX2" && push1== false)
        {
            TireRodA = true;
            TireRodB = false;
            open2.SetActive(true);
            close2.SetActive(false);
            push1 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX2" && push1 == true)
        {
            TireRodA = false;
            TireRodB = true;
            open2.SetActive(false);
            close2.SetActive(true);
            push1 = false;

        }

        if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX3" && push2== false)
        {
            TireRodC = true;
            TireRodA = false;
            open3.SetActive(true);
            close3.SetActive(false);
            push2 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX3" && push2 == true)
        {
            TireRodC = false;
            TireRodA = true;
            open3.SetActive(false);
            close3.SetActive(true);
            push2 = false;

        }

        if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX4" && push3 == false)
        {
            TireRodC = true;
            TireRodB = true;
            TireRodD = false;
            open4.SetActive(true);
            close4.SetActive(false);
            push3 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && collision.tag == "BOX4" && push3 == true)
        {
            TireRodC = false;
            TireRodB = false;
            TireRodD = true;
            open4.SetActive(false);
            close4.SetActive(true);
            push3 = false;

        }

    }



    private void OnTriggerExit2D(Collider2D collision)
    {
      //  E.SetActive(false);
    }

}
