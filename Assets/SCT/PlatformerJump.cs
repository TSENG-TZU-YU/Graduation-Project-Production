using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerJump : MonoBehaviour
{
    public bool OnTop ;
    GameObject bouncer;  //所有物體
    Animator anim;
    public Vector2 velocity;
  

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
     

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
    
        if (OnTop==true)
        {

   
            anim.SetBool("jump", true);
         
            bouncer = collision.gameObject;
        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        OnTop = true;
    }
    private void OnTriggerExit2D()
    {
        OnTop = false;
        StartCoroutine(Jumpfale());

    }
    void Jump()
    {
        bouncer.GetComponent<Rigidbody2D>().velocity = velocity;
    }

    IEnumerator Jumpfale()
    {
        yield return new WaitForSeconds(0.8f);
        anim.SetBool("jump", false);
   
    }
}
