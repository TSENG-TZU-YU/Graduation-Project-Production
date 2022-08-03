using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class LookAt : MonoBehaviour
{

    public GameObject c1, c2;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<CinemachineVirtualCamera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }



    private void OnTriggerStay2D(Collider2D collision)
    {




       if (collision.tag == "Player")
          {
              c1.SetActive(false);
          c2.SetActive(true);
              this.GetComponent<CinemachineVirtualCamera>().enabled = true;
          }

      //  Camera.main.orthographic = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {




       if (collision.tag == "Player")
          {
              c1.SetActive(true);
          c2.SetActive(false);
              this.GetComponent<CinemachineVirtualCamera>().enabled = false;
          }

     //   Camera.main.orthographic = false;
    }
}

