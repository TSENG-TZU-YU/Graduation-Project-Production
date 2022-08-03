using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb;
    bool facingRight = true;

    public bool isGround;
    public bool isJump;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public float jumpForce;
    public GameObject Player;

    [SerializeField]
    private PhysicsMaterial2D noFriction;
    [SerializeField]
    private PhysicsMaterial2D fullFriction;

    public Vector2 RespawePosition;

    public Animator anim; //要取得另一物件的動畫須公開動畫

    public GameObject[] color;
    public GameObject[] colorcan;

    public bool die;
    public Image theImage;
    public float transitionSeed = 2f;
    public bool shouldReveal;



    //第二關
    public GameObject start2,Secondpass;

    public bool down;

    //footstep
    public ParticleSystem footstepts;
    private ParticleSystem.EmissionModule footEmission;


    //第三關
    public GameObject start3;

    public bool canmove;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //  anim = GetComponent<Animator>(); 不公開
        shouldReveal = true;
        die = false;
        RespawePosition = transform.position;
        footEmission = footstepts.emission;
  


    }



    // Update is called once per frame
    void Update()
    {
        if(canmove==true)
        {
            move();
        }
       

        // MoveControiler();


        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("sc01 01");
        }


  




    }
  /*  void MoveControiler()
    {
        if(!SAY.isTalking)
        {
           move();

           footEmission.rateOverTime = 50;
        }
        else if(SAY.isTalking)
        {
            anim.SetBool("run", false);
            footEmission.rateOverTime = 0;
        }
    }*/

    

    public void move()
    {

        float input = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

       if(input==1 && isGround==true)
        {
            anim.SetBool("run", true);
            
        }
        else if(input==-1 && isGround == true)
        {
            anim.SetBool("run", true);
           
        }
       else if(input==0 && isGround == true)
        {
            anim.SetBool("run", false);
         
        }
  

        if (input > 0 && facingRight == false && down == false)
        {
            Flip();
        }
        else if (input < 0 && facingRight == true && down == false)
        {
            Flip();
        }

        if (isGround && input != 0)
        {

            rb.sharedMaterial = noFriction;
        }


        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            dust();

        }
        

        if (rb.velocity.y < 0 && isGround == false) //下墜
        {
            anim.SetBool("jumpfall", true);
            anim.SetBool("jump", false);
            anim.SetBool("run", false);

        }
        else if(rb.velocity.y > 0 && isGround == false)
        {
            anim.SetBool("jump", true);
            anim.SetBool("jumpfall", false);
            anim.SetBool("run", false);
        }
        else if (isGround == true)
        {
            isJump = false;
            anim.SetBool("jumpfall", false);
            anim.SetBool("jump", false);
        }


        if (down == true)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
            anim.SetBool("run", false);
            anim.SetBool("jumpfall", false);
            

        }
        else if(down==false)
        {
            rb.velocity = new Vector2(input * speed, rb.velocity.y);
        }

        //footstep
        if (Input.GetKeyDown(KeyCode.A) && isGround && down == false)
        {
            dust();
        }
        else if (Input.GetKeyDown(KeyCode.D) && isGround && down == false)
        {
            dust();
        }


        /*   if(input!=0 && isGround && down == false)
         {
             footEmission.rateOverTime = 10.5f;
         }
         else
         {
             footEmission.rateOverTime = 0;
         }*/



    }



    void Flip()
    {
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        facingRight = !facingRight;
      



    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
      


        if(collision.tag=="CheckPoint") //復活點
        {
            RespawePosition = collision.transform.position;
           
        }



        if(collision.tag=="第二關")
        {
            transform.position = start2.transform.position;
           
            Secondpass.SetActive(true);
        }

        if (collision.tag == "第三關")
        {
            transform.position = start3.transform.position;

            Secondpass.SetActive(true);
        }


        if (collision.tag == "fallplat")
        {
            down = true;       
        }
        else if(collision.tag=="fallwalk")
        {

            down = false;
        }

        //拿到color
        if(collision.tag=="red")
        {
            color[0].SetActive(true);
            colorcan[0].SetActive(true);
        }
        if (collision.tag == "blue")
        {
            color[4].SetActive(true);
            colorcan[4].SetActive(true);
        }
        if (collision.tag == "orange")
        {
            color[1].SetActive(true);
            colorcan[1].SetActive(true);
        }
        if (collision.tag == "yellow")
        {
            color[2].SetActive(true);
            colorcan[2].SetActive(true);
        }
        if (collision.tag == "green")
        {
            color[3].SetActive(true);
            colorcan[3].SetActive(true);
        }
        if (collision.tag == "purple")
        {
            color[5].SetActive(true);
            colorcan[5].SetActive(true);
        }



    }

    void dust()
    {
        footstepts.Play();
    }






}
