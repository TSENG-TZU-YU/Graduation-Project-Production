using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DieShader : MonoBehaviour
{
    private Image theImage;
    public float transitionSeed = 2f;
    private bool shouldReveal;

    // Use this for initialization
    void Start()
    {
        theImage = GetComponent<Image>();

        shouldReveal = true;
    }

    private void Update()
    {
       /* if(Input.GetKeyDown(KeyCode.E))
        {
            shouldReveal = !shouldReveal;
        }*/

        if (shouldReveal)
        {
            theImage.material.SetFloat("_cutoff", Mathf.MoveTowards(theImage.material.GetFloat("_cutoff"), -0.1f - theImage.material.GetFloat("_smoothing"), transitionSeed * Time.deltaTime));
     
        }
        else
        {
            theImage.material.SetFloat("_cutoff", Mathf.MoveTowards(theImage.material.GetFloat("_cutoff"), 1.1f, transitionSeed * Time.deltaTime));
        }
    }


}
