using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlat : MonoBehaviour
{

    public GameObject PlatForm;

    public Transform StartPoint;

    public Transform MinPoint1;
    public Transform MinPoint2;

    public Transform EndPoint;

    public float MoveSpeed;
 
    public Vector2 target;


    // Start is called before the first frame update
    void Start()
    {
        target = MinPoint1.position;
    }

    // Update is called once per frame
    void Update()
    {
       
       
        PlatForm.transform.position = Vector2.MoveTowards(PlatForm.transform.position, target, MoveSpeed * Time.deltaTime);


        if (PlatForm.transform.position == MinPoint1.position)
        {
            target = EndPoint.position;


        }

        if (PlatForm.transform.position == EndPoint.position)
        {
            target = MinPoint2.position;

        }

        if (PlatForm.transform.position == MinPoint2.position)
        {
            target = StartPoint.position;
        }

        if (PlatForm.transform.position == StartPoint.position)
        {
            target = MinPoint1.position;

        }

    }

}
