using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEyeplat : MonoBehaviour
{

    public GameObject Red;




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
        if (collision.tag == "Red eye")
        {

            Red.GetComponent<BoxCollider2D>().enabled = false;
            Red.GetComponent<SpriteRenderer>().enabled = false;
        }
  
    }


    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "Red eye")
        {

            Red.GetComponent<BoxCollider2D>().enabled = true;
            Red.GetComponent<SpriteRenderer>().enabled = true;
        }

    }


}
