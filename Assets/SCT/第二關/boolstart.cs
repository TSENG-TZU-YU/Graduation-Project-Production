﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolstart : MonoBehaviour
{
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("bookfull", false);
        }
    }
}
