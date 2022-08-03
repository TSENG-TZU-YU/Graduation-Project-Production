using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{

    public AudioSource audiosource;
    public AudioClip walk;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void walksource()
    {
        audiosource.clip = walk;
        audiosource.Play();
    }
}
