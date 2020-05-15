using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public delegate void BlackScreenDelegate();

public class BlackScreen : MonoBehaviour
{
    public static BlackScreenDelegate TextHide;
    public GameObject TextScreen;
    public GameObject[] SlideScreen;
    private int index = 1;
    private Color color;
    private float deltaTime = 0.05f;

    public void goBack()
    {
        StartCoroutine(FadeOut());
    }
    IEnumerator FadeOut()
    {
        GetComponent<Button>().enabled = false;
        color = GetComponentInChildren<TMPro.TextMeshProUGUI>().color;
        while (color.a > 0f)
        {
            GetComponentInChildren<TMPro.TextMeshProUGUI>().color = color;
            color.a -= 0.05f;
            yield return new WaitForSeconds(deltaTime);
        }
        color.a = 1f;
        GetComponentInChildren<TMPro.TextMeshProUGUI>().color = color;
        GetComponent<Button>().enabled = true;
        if (SlideScreen != null && index < SlideScreen.Length)
        {
            SlideScreen[index-1].SetActive(false);
            SlideScreen[index++].SetActive(true);
        }
        else
        {
            if (TextScreen != null)
            {
                TextScreen.SetActive(false);
                TextScreen = null;
            }
            else if (SlideScreen != null)
            {
                SlideScreen[index - 1].SetActive(false);
                SlideScreen = null;
            }
            TextHide();
            gameObject.SetActive(false);
            index = 0;
        }
    }
}
