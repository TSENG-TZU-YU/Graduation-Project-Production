using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despaint : MonoBehaviour
{
    public int pa;
    public GameObject paint;
    public Transform []paintPointA;
  //  public PolygonCollider2D po;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(desp());
    }

    // Update is called once per frame
    void Update()
    {
        if(pa==3)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            pa++;

            GetComponent<PolygonCollider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
       

        }

    }



    IEnumerator desp()
    {
        yield return new WaitForSeconds(2);
        int num = UnityEngine.Random.Range(0, paintPointA.Length);
        paint.transform.position = paintPointA[num].transform.position;
        GetComponent<PolygonCollider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(3);
        GetComponent<PolygonCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(desp());
    }



}
