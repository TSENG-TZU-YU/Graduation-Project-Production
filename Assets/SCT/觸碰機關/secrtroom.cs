using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secrtroom : MonoBehaviour
{
    public GameObject eyeroom;

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
            eyeroom.SetActive(true);
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(room());

        }
    }

    

    IEnumerator room()
    {
        yield return new WaitForSeconds(4);
        eyeroom.SetActive(false);
        GetComponent<BoxCollider2D>().enabled = true;

    }
}
