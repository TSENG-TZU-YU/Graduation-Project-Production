using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class lookat1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<CinemachineVirtualCamera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            this.GetComponent<CinemachineVirtualCamera>().enabled = true;
        }

    
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            this.GetComponent<CinemachineVirtualCamera>().enabled = false;
        }

      
    }
}
