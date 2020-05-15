using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScreens : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Next = null, Current = null;

    void OnMouseUpAsButton()
    {
        if (Next != null)
        {
            foreach (GameObject Moving in Next) Moving.SetActive(true);
            foreach (GameObject Prev in Current) Prev.SetActive(false);
        }
    }
}
