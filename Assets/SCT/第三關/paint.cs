using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paint : MonoBehaviour
{
    public GameObject [] break1;

    public GameObject d,light,say;
    despaint p;
    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        p = d.GetComponent<despaint>();
    }

    // Update is called once per frame
    void Update()
    {

        if(p.pa==1)
        {
            break1[0].SetActive(true);
            anim.SetBool("bell", true);
        }

        if (p.pa== 2)
        {
            break1[1].SetActive(true);
        }

        if (p.pa == 3)
        {
            break1[2].SetActive(true);
            light.SetActive(true);
            say.SetActive(true);
            p.paint.SetActive(false);
        }
    }

    
}
