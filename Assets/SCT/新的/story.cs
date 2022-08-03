using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    public GameObject st,st1,flowr;

    // Start is called before the first frame update
    void Start()
    {
        flowr.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag==("Player"))
        {
            st.SetActive(true);
            flowr.SetActive(true);
            st1.SetActive(false);
            GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
}
