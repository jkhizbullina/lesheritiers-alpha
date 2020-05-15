using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void JournalDelegate();

public class JournalText : MonoBehaviour
{
    public static JournalDelegate TextShow;
    public GameObject Reward;

    public GameObject JournalScreen;
    void Start()
    {
        JournalOpen();
        Reward.SetActive(true);
    }

    void JournalOpen()
    {

        GameController.Screen.SetActive(true);
        GameController.Screen.GetComponent<BlackScreen>().TextScreen = JournalScreen;
        JournalScreen.SetActive(true);
        TextShow();
    }

    void OnMouseUpAsButton()
    {
        JournalOpen();
    }
}
