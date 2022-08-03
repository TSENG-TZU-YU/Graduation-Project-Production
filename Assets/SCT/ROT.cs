using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROT : MonoBehaviour
{



    // Start is called before the first frame update
    void Start()
    {

     

    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(ro());


        //transform.RotateAround

    }

    IEnumerator ro()
    {

        if(transform.eulerAngles.z>=0 & transform.eulerAngles.z <90)
        {
            yield return new WaitForSeconds(2);

            Quaternion a = transform.rotation;
            Quaternion b = Quaternion.Euler(0, 0,90);
            transform.rotation = Quaternion.RotateTowards(a, b, 90* Time.deltaTime);
        }
       
        if ( transform.eulerAngles.z>=90 & transform.eulerAngles.z <180)
        {
            yield return new WaitForSeconds(2);
            Quaternion a = transform.rotation;
            Quaternion b = Quaternion.Euler(0, 0, 180);
            transform.rotation = Quaternion.RotateTowards(a, b, 60 * Time.deltaTime);
         

        }

        if (transform.eulerAngles.z >= 180 & transform.eulerAngles.z < 270)
        {
            yield return new WaitForSeconds(2);
            Quaternion a = transform.rotation;
            Quaternion b = Quaternion.Euler(0, 0, 270);
            transform.rotation = Quaternion.RotateTowards(a, b, 30 * Time.deltaTime);


        }

        if (transform.eulerAngles.z >= 270 & transform.eulerAngles.z < 360)
        {
            yield return new WaitForSeconds(2);
            Quaternion a = transform.rotation; //原本位置
            Quaternion b = Quaternion.Euler(0, 0, 360);
            transform.rotation = Quaternion.RotateTowards(a, b, 30 * Time.deltaTime);  //a到b的速度

            if(transform.eulerAngles.z==360.0f)
            {
                transform.eulerAngles = Vector3.zero;   //角度歸0
            }
           
        }
    }

 
  

}
