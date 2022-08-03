using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tierod : MonoBehaviour
{

    public bool TireRodA;
    public bool TireRodB;
    public bool TireRodC;
    public bool TireRodD;

    public bool push;
    public bool push1;
    public bool push2;
    public bool push3;

    public GameObject E;


    public GameObject moveplaneA;
    public GameObject moveplaneB;
    public GameObject moveplaneC;
    public GameObject moveplaneD;

    public Transform StartPointA;
    public Transform StartPointB;
    public Transform StartPointC;
    public Transform StartPointD;

    public Transform EndPointA;
    public Transform EndPointB;
    public Transform EndPointC;
    public Transform EndPointD;

    public float MoveSpeed;

    public Vector2 targetA;
    public Vector2 targetB;
    public Vector2 targetC;
    public Vector2 targetD;

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
        if (TireRodA == true)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = EndPointA.position;

        }
        else if (TireRodA == false)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = StartPointA.position;

        }


        if (TireRodB==true)
        {
            moveplaneB.transform.position = Vector2.MoveTowards(moveplaneB.transform.position, targetB, MoveSpeed * Time.deltaTime);

            targetB = EndPointB.position;

        }
        else if (TireRodB == false)
        {
            moveplaneB.transform.position = Vector2.MoveTowards(moveplaneB.transform.position, targetB, MoveSpeed * Time.deltaTime);

            targetB = StartPointB.position;

        }

        if (TireRodC == true)
        {

            moveplaneC.transform.position = Vector2.MoveTowards(moveplaneC.transform.position, targetC, MoveSpeed * Time.deltaTime);

            targetC = EndPointC.position;
        }
        else if (TireRodC == false)
        {

            moveplaneC.transform.position = Vector2.MoveTowards(moveplaneC.transform.position, targetC, MoveSpeed * Time.deltaTime);

            targetC = StartPointC.position;
        }

        if (TireRodD == true)
        {

            moveplaneD.transform.position = Vector2.MoveTowards(moveplaneD.transform.position, targetD, MoveSpeed * Time.deltaTime);

            targetD = EndPointD.position;
        }
        else if (TireRodD == false)
        {

            moveplaneD.transform.position = Vector2.MoveTowards(moveplaneD.transform.position, targetD, MoveSpeed * Time.deltaTime);

            targetD = StartPointD.position;
        }



    }

    private void OnTriggerStay2D(Collider2D collision)
    {
     

        if (Input.GetKeyDown(KeyCode.E) && push == false && collision.tag == "BOX1")
        {
            print("1");
            TireRodB = true;
            TireRodD = true;
            push = true;


        }
        else if (Input.GetKeyDown(KeyCode.E) && push==true && collision.tag == "BOX1")
        {
            print("2");
            TireRodB = false;
            TireRodD = false;
            push = false;


        }



        if (Input.GetKeyDown(KeyCode.E) && push1 == false && collision.tag == "BOX2")
        {
            print("3");
            TireRodA = true;
            TireRodB = false;
            push1 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && push1 == true && collision.tag == "BOX2")
        {
            print("4");
            TireRodA = false;
            TireRodB = true;
            push1 = false;


        }


        if (Input.GetKeyDown(KeyCode.E) && push2 == false && collision.tag == "BOX3")
        {
            print("5");
            TireRodC = true;
            TireRodA = false;
            push2 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && push2 == true && collision.tag == "BOX3")
        {
            print("6");
            TireRodC = false;
            TireRodA = true;
            push2 = false;


        }

        if (Input.GetKeyDown(KeyCode.E) && push3 == false && collision.tag == "BOX4")
        {
            print("7");
            TireRodC = true;
            TireRodB = true;
            TireRodD = false;
            push3 = true;

        }
        else if (Input.GetKeyDown(KeyCode.E) && push3 == true && collision.tag == "BOX4")
        {
            print("8");
            TireRodC = false;
            TireRodB = false;
            TireRodD = true;
            push3 = false;


        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BOX4")
        {
            E.SetActive(true);
        }
    }

  /*  private void OnTriggerExit2D(Collider2D collision)
    {
        E.SetActive(false);
    }*/


}
