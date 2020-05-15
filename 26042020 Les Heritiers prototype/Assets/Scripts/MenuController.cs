using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    //public GameObject[] Slots;
    //public byte index = 0;
    //private bool[] empty;

    void Start()
    {
        Pickup.PickObject += Picked;
        Pickup.UseObject += Used;
    }

    void SortChildren()
    {
        float y = 3.7f;
        foreach (Transform child in transform)
        {
            child.localPosition = Vector3.up*y;
            y -= 1.85f;
        }
    }

    void Picked()
    {
        float y = 3.7f;
        int i = 0;
        for (i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).localPosition != Vector3.up * y)
            {
                break;
            }
            else
            {
                y -= 1.85f;
            }
        }
        transform.GetChild(transform.childCount - 1).localPosition = Vector3.up * (y);
        transform.GetChild(transform.childCount - 1).SetSiblingIndex(i);
        for (; i < transform.childCount; i++)
            transform.GetChild(i).SetSiblingIndex(i);
    }

    void Used()
    {
        //SortChildren();
    }

}
