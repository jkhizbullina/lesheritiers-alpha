using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Trigger = null, Result = null, Move = null;
    public string Myhint;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Trigger)
        {
            other.gameObject.GetComponent<Pickup>().ispicked = 2;
        }
    }

    void Use()
    {
        if (Result != null)
        {
            Result.gameObject.SetActive(true);
            Result.gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
            if (Move != null)
            {
                Move.SetActive(true);
                gameObject.SetActive(false);
            }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Trigger)
        {
            if (other.gameObject.GetComponent<Pickup>().ispicked == 3) Use();
            else
            {
                other.gameObject.GetComponent<Pickup>().ispicked = 1;
            }
        }
    }

    void OnMouseUp()
    {
        if (Trigger == null) Use();
        else GameController.Tooltip.GetComponent<TMPro.TextMeshProUGUI>().text = Myhint;
    }
}
