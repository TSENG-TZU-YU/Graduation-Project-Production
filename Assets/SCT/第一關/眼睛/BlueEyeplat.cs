using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEyeplat : MonoBehaviour
{
    public GameObject Blue;



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
      
        if (collision.tag == "Blue eye")
        {

            Blue.GetComponent<BoxCollider2D>().enabled = false;
            Blue.GetComponent<SpriteRenderer>().enabled = false;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      
        if (collision.tag == "Blue eye")
        {
            Blue.GetComponent<BoxCollider2D>().enabled =true;
            Blue.GetComponent<SpriteRenderer>().enabled = true;

        }

    }

 

}
