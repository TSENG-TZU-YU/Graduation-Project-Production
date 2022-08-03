using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouse : MonoBehaviour
{
   
    public bool m;

    public RectTransform canvas;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(m==true)
         {
              //將滑鼠座標轉換至UI座標的方法
        Vector2 Pos;
       // RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, null, out Pos);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas,new Vector2(Input.mousePosition.x,Input.mousePosition.y+300),  null, out Pos);
            //UI跟隨滑鼠
            gameObject.transform.localPosition = Pos;
         }

         if(Input.GetMouseButton(0))
         {
             m = true;
             GetComponent<BoxCollider2D>().enabled = false;
             Cursor.visible = false;
         }





    }




}
