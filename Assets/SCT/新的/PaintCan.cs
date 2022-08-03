using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCan : MonoBehaviour
{
    public GameObject moveplaneA;
    public Transform EndPointA;
    public float MoveSpeed;
    public Vector2 targetA;
    public bool go, change;
    public Animator anim;
    public GameObject cans;

    public GameObject C;   //新顏料罐

    public GameObject d;
    player p;




    // Start is called before the first frame update
    void Start()
    {
        change = false;

        p = d.GetComponent<player>();



    }

    // Update is called once per frame
    void Update()
    {

        if (go == true)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = EndPointA.position;


            anim.SetBool("paint cans", true);
            StartCoroutine(ch());
            p.down = true;
            




        }

        if (go == false)
        {
            anim.SetBool("paint cans", false);

            StartCoroutine(ch1());
            p.down = false;
         




        }

        if (change && Input.GetKeyDown(KeyCode.Space))
        {
            go = false;
        }



    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        C.SetActive(false);

        if (collision.tag == "Player" && !change)
        {
            

            if (Input.GetKey(KeyCode.Space))
            {
                go = true;

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

}
