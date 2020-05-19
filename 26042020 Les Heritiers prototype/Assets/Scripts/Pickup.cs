using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void PickupDelegate();

public class Pickup : MonoBehaviour
{
    public static PickupDelegate UseObject;
    public static PickupDelegate PickObject;

    public byte ispicked;
    private Vector3 placed = new Vector3(0, 0, -1);
    private Vector3 scaled = new Vector3(1, 1, 1);
    void Start()
    {
        ispicked = 0;
    }
    void OnMouseUpAsButton()
    {
        if (ispicked == 0)
        {
            ispicked = 1;
            transform.parent = GameController.Menu.transform;
            PickObject();
            placed = transform.localPosition;
            //Debug.Log(placed);
        }
        else if (ispicked == 1)
            transform.localPosition = placed;
        else if (ispicked == 2)
        {
            ispicked = 3;
            //GetComponent<Collider2D>().enabled = false;
            transform.parent = null;
            UseObject();
            Destroy(gameObject);
        }
    }

    void OnMouseDrag()
    {
        if (ispicked > 0)
        {
            GetComponent<ShowName>().enabled = false;
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }
}
