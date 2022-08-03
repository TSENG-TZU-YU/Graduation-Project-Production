using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallplatwalk : MonoBehaviour
{
    Rigidbody2D playerRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = FindObjectOfType<player>().GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerRigidbody.velocity = new Vector2(0, playerRigidbody.velocity.y);
        }
    }

    IEnumerator walk()
    {
        yield return new WaitForSeconds(0.5f);
        playerRigidbody.WakeUp();
    }
}
