using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    public GameObject P;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*   Vector3 Player = P.transform.position;

            Player.z = 10;


            Vector3 look = Camera.main.ScreenToWorldPoint(Player);

            transform.rotation = Quaternion.LookRotation(look, Vector3.back);*/

        Vector3 Player = P.transform.position;
        transform.rotation = Quaternion.LookRotation(Player - gameObject.transform.position);
    }
}
