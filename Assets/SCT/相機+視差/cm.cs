﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cm : MonoBehaviour
{
   

    public CinemachineVirtualCamera len;

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
            len.Priority = 16;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            len.Priority = 10;


        }
    }

 
}
