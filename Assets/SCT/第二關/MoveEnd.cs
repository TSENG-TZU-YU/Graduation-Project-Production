using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnd : MonoBehaviour
{

    public GameObject moveplaneA;
    public Transform StartPointA;
    public Transform EndPointA;
    public float MoveSpeed;
    public Vector2 targetA;

    public bool start;
    public GameObject mouth;
    public float st;

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
    

        if (start == true)
        {
            moveplaneA.transform.position = Vector2.MoveTowards(moveplaneA.transform.position, targetA, MoveSpeed * Time.deltaTime);

            targetA = EndPointA.position;


        }

       if (p.die==true)
        {
            StartCoroutine(di());
            mouth.SetActive(false);
            start = false;

        }

       if(moveplaneA.transform.position==EndPointA.transform.position)
        {
            mouth.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            StartCoroutine(star());
          
        }

       
    }

    IEnumerator mo()
    {
        yield return new WaitForSeconds(st);
        mouth.SetActive(true);
  
      
    }

    IEnumerator di()
    {
        yield return new WaitForSeconds(1);

        moveplaneA.transform.position = new Vector3(1006.534f, 8.51223f, 0);
    }

    IEnumerator star()
    {
        yield return new WaitForSeconds(1);
        start = true;
        StartCoroutine(mo());

    }

}
