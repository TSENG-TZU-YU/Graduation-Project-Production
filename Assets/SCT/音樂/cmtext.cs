﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cmtext : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0.01f, 0, 0);
        Cursor.visible = false;
     
    }
}
