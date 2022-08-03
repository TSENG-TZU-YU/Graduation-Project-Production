using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SAY : MonoBehaviour
{
    public static Flowchart FlowchartManager;


    // Start is called before the first frame update
    void Start()
    {
        FlowchartManager = GameObject.Find("對話管理器").GetComponent<Flowchart>();
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static bool isTalking
    {
        get { return FlowchartManager.GetBooleanVariable("對話中"); }
    }


}
