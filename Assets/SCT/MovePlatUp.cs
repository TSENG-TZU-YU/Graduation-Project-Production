using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatUp : MonoBehaviour
{
    public bool up;



    public GameObject moveplaneA;
    public GameObject moveplaneB;

    public Transform StartPointA;
    public Transform StartPointB;

    public Transform EndPointA;
    public Transform EndPointB;

    public float MoveSpeed;

    public Vector2 targetA;
    public Vector2 targetB;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(up==true)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = EndPointA.position;

            moveplaneB.transform.position = Vector2.MoveTowards(moveplaneB.transform.position, targetB, MoveSpeed * Time.deltaTime);

            targetB = EndPointB.position;

        }
        else if(up==false)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = StartPointA.position;


            moveplaneB.transform.position = Vector2.MoveTowards(moveplaneB.transform.position, targetB, MoveSpeed * Time.deltaTime);

            targetB = StartPointB.position;
        }


    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
         
            up = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            up = false;
        }
    }
}
