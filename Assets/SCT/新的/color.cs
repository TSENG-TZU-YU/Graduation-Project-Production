using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
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
        if(collision.tag=="Player")
        {
         
            flowr.SetActive(true);
            st1.SetActive(false);
            st.SetActive(true);
        }
    }
}
