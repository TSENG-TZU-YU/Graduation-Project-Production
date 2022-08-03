using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject[] bullet;
    private GameObject BulletClone;

    private float time = 0;
    private float BulletIntervea;

    public Animator anim;
    public float se;

    public GameObject d;
    player p;


    // Start is called before the first frame update
    void Start()
    {
        BulletIntervea = 0.8f;

        p = d.GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {


        if (p.die == true)
        {

            Destroy(BulletClone);

        }

        StartCoroutine(mo());

   
    }

    void mouth1()
    {
       
    
     
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

        int num = UnityEngine.Random.Range(0, bullet.Length);
        BulletClone = (GameObject)Instantiate(bullet[num], pos, rot);
        BulletClone.AddComponent<BulletState>();

        Destroy(BulletClone, 3);
     
    
    }


    IEnumerator mo()
    {
        yield return new WaitForSeconds(se);
        anim.SetBool("流言", true);

    }
}
