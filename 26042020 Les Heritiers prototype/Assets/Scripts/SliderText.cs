using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderText : MonoBehaviour
{
    public GameObject[] SlideScreen;

    public void StartSlider()
    {
        if (SlideScreen.Length > 0)
        {
            GameController.Screen.SetActive(true);
            GameController.Screen.GetComponent<BlackScreen>().SlideScreen = SlideScreen;
            SlideScreen[0].SetActive(true);
        }
    }
}
