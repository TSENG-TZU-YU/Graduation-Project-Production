using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallplat : MonoBehaviour
{
    public GameObject fall;
    Rigidbody2D playerRigidbody;
    public bool down;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = FindObjectOfType<player>().GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       if(down==true)
        {
            playerRigidbody.velocity = new Vector2(0, playerRigidbody.velocity.y);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            down = true;
            fall.SetActive(false);

        }

        
    }

}
