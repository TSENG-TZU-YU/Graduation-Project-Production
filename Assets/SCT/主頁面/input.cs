using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{

    public GameObject put;
    public GameObject page,page3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void input0()
    {
        StartCoroutine(put0());
    }



    public void page1()  //翻頁音效
    {
        page.SetActive(true);
        StartCoroutine(page2());
    }
    public void page4()  //翻封面音效
    {
        page3.SetActive(true);
        StartCoroutine(page5());
    }
    IEnumerator put0()
    {
        yield return new WaitForSeconds(3);
        put.SetActive(true);

    }

     IEnumerator page2()
    {
        yield return new WaitForSeconds(0.5f);
        page.SetActive(false);
    }

    IEnumerator page5()
    {
        yield return new WaitForSeconds(0.5f);
        page3.SetActive(false);
    }
}
