using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyecue : MonoBehaviour
{
    public GameObject cue;

    public Animator anim;


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
        if (collision.tag == "Player")
        {
           
            anim.SetBool("eyecue", true);
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("eyecue", false);

        }
    }



 
}
