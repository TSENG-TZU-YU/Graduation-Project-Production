using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BulletState : MonoBehaviour
{
    static public int BullstAtk;
    public float BulletSpeed;



    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(-BulletSpeed, 0, 0);



 
      /*  if(transform.position.x< 1030)
        {
            Destroy(this.gameObject);
        }*/

    }

  
}
