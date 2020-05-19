using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public GameObject[] roomscreens;
    public GameObject[] outscreens;
    private int room;

    void Start()
    {
        room = 3;
        ArrowClick.ClickArrow += RoomCycle;
        JournalText.TextShow += RoomHide;
        BlackScreen.TextHide += IntroScreen;
        foreach (GameObject wall in roomscreens) wall.SetActive(false);
        //roomscreens[room - 1].SetActive(true);
    }
    void RoomCycle()
    {
        bool f;
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < 0) f = false;
        else f = true;
        roomscreens[room - 1].SetActive(false);
        if (f)
        {
            if (room < roomscreens.Length)
            {
                room++;
                GameController.Background.transform.position += Vector3.right * 0.5f;
            }
            else
            {
                room = 1;
                GameController.Background.transform.position = Vector3.up * 0.5f;
            }
        }
        else
        {
            if (room > 1) room--;
            else room = (byte)roomscreens.Length;
        }
        roomscreens[room - 1].SetActive(true);
    }

    void IntroScreen()
    {
        outscreens[0].SetActive(true);
        GameController.Gameplay.SetActive(true);
        BlackScreen.TextHide -= IntroScreen;
        BlackScreen.TextHide += RoomShow;
    }

    void RoomShow()
    {
        GameController.Tooltip.SetActive(true);
        GameController.Gameplay.SetActive(true);
        roomscreens[room - 1].SetActive(true);
    }
    void RoomHide()
    {
        GameController.Tooltip.SetActive(false);
        GameController.Gameplay.SetActive(false);
        roomscreens[room - 1].SetActive(false);
    }
}
