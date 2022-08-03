using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class video : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(v());
    }

    IEnumerator v()
    {
        yield return new WaitForSeconds(0.3f);
        GetComponent<RawImage>().enabled = true;
    }
}
