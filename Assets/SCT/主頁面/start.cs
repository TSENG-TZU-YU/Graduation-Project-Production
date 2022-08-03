using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public Animator anim,animb;
    public GameObject b,b1;

    public GameObject can;
    public bool s = true;
    public GameObject d,st;
    player p;

    // Start is called before the first frame update
    void Start()
    {
        p = d.GetComponent<player>();
        p.canmove = false;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TOstart()
    {
        // SceneManager.LoadScene("01");
       
       
      
        animb.SetBool("start", true);
        b.SetActive(false);
       // b1.SetActive(false);
    
        st.SetActive(true);

      //   anim.SetBool("start", true);
      //   StartCoroutine(an());
      //  StartCoroutine(cc());
      // StartCoroutine(move());
    }
    public void TOend()
    {
       
            Application.Quit();
        
    }


    public IEnumerator cc()
    {
        yield return new WaitForSeconds(3f);
        can.SetActive(false);

    }

    public IEnumerator move()
    {
        yield return new WaitForSeconds(3.617f);
        p.canmove = true;
       // can1.SetActive(true);
    }

    public IEnumerator an()
    {
        yield return new WaitForSeconds(3f);
        anim.SetBool("start", false);
    }
}
