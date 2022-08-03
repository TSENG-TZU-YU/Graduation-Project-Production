using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class waterfull : MonoBehaviour
{
  
    public bool waterf, waterf1;

    public AudioSource m;

    // Start is called before the first frame update
    void Start()
    {
        m.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(waterf)
        {
            if(m.volume <= 0.08)
            {
                m.volume += 0.002f;
            }

       

        }
        if(!waterf)
        {
            if (m.volume >= 0)
            {
                m.volume -= 0.002f;
            }
        }

        if (waterf1)
        {
           
            if (m.volume <= 0.2)
            {
                m.volume += 0.01f;
            }
        }
        if (!waterf1)
        {
         
            if (m.volume >= 0.081)
            {
                m.volume -= 0.002f;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="waterfull")
        {

            waterf = true;

        }

        if (collision.tag == "waterfull1")
        {

            waterf1 = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "waterfull")
        {

            waterf = false;
        }

        if (collision.tag == "waterfull1")
        {

            waterf1 = false;

        }
    }
}
