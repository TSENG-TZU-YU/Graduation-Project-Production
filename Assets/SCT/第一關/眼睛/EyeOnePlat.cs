﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeOnePlat : MonoBehaviour
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

    void close()
    {
        anim.SetBool("eyeopen", false);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("eyeopen", true);
        }
    }
}
