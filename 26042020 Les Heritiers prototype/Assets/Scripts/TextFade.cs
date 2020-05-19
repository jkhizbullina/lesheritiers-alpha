using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour
{
    private float deltaTime = 0.1f;
    private Color color;

    void OnEnable()
    {
        GetComponentInParent<Button>().enabled = false;
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
        Debug.Log("Enabled");
        color = GetComponent<TMPro.TextMeshProUGUI>().color;
        color.a = 0f;
        while (color.a < 1f)
        {
            GetComponent<TMPro.TextMeshProUGUI>().color = color;
            color.a += 0.05f;
            yield return new WaitForSeconds(deltaTime);
        }
        GetComponentInParent<Button>().enabled = true;
    }
}
