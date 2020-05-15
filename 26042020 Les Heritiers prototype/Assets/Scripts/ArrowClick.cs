using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void ArrowDelegate();

public class ArrowClick : MonoBehaviour

{
    public static ArrowDelegate ClickArrow;

    /*void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    void OnMouseExit()
    {
        GetComponent<SpriteRenderer>().color = Color.white;
    }*/

    public void Click()
    {
        ClickArrow();
    }
}
