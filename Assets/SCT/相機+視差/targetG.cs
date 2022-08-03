using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;    



public class targetG : MonoBehaviour
{
    public CinemachineVirtualCamera len;

    public bool far13,far130, near10,near109;

    void Update()
    {
        if(far13==true)
        {
            if (len.m_Lens.OrthographicSize < 13)
            {
                len.m_Lens.OrthographicSize += 0.1f;
            }

        }
        if (far130 == true)
        {
            if (len.m_Lens.FieldOfView < 85)
            {
                len.m_Lens.FieldOfView += 0.2f;
            }

        }
        if (near10==true)
        {
            if (len.m_Lens.FieldOfView > 60)
            {
                len.m_Lens.FieldOfView -= 0.1f;
            }
        }
        if (near109 == true)
        {
            if (len.m_Lens.FieldOfView > 109)
            {
                len.m_Lens.FieldOfView -= 0.2f;
            }
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "camera far13")
        {
            far13 = true;
            far130 = false;
            near10 = false;
            
        }
        if (collision.gameObject.tag == "camera far15")
        {
            far130 = true;
            far13 = false;
            near10 = false;
            near109 = false;

        }

        if (collision.gameObject.tag == "camera near10")
        {
            near10 = true;
            far130 = false;
            far13 = false;
            near109 = false;

        }
        if (collision.gameObject.tag == "camera near7")
        {
            near109 = true;
            far130 = false;
            far13 = false;
            near10 = false;

        }
    }
}
