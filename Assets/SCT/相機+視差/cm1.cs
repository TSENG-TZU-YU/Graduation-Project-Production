using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cm1 : MonoBehaviour
{
    public GameObject cm2,cm0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            cm2.SetActive(true);
            cm0.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cm2.SetActive(false);
            cm0.SetActive(true);
        }
    }
}
