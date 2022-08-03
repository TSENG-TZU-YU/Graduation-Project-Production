using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painta : MonoBehaviour
{
    public Color curColorRed;


    

    // Start is called before the first frame update
    void Start()
    {
  
       
    }

    // Update is called once per frame
    void Update()
    {


        SpriteRenderer sp = GetComponent<SpriteRenderer>();

       // sp = GetComponent<SpriteRenderer>();    //初始化sprite renderer


        if (sp.color == curColorRed)
        {
            print("red");
        }
        
    }

   /* private void red1()
    {
        SpriteRenderer sp = gameObject.GetComponent<SpriteRenderer>();

        sp = GetComponent<SpriteRenderer>();    //初始化sprite renderer


        if (sp.color == curColor)
        {
            print("red");
        }


        //  sp.color = new Color32(255, 23, 0, 255);

    }*/
}
