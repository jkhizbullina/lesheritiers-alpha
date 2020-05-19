using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowName : MonoBehaviour
{
    public string Myname;

    void Start()
    {
    }

    void OnMouseEnter()
    {
        if (enabled) GameController.Tooltip.GetComponent<TMPro.TextMeshProUGUI>().text = Myname;
    }

    void OnMouseExit()
    {
        if (enabled) GameController.Tooltip.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }
}
