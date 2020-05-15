using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SynchronizedChange : MonoBehaviour
{
    public GameObject[] Next;
    public GameObject[] Current;
    public int NextCount = 0, CurrentCount = 0;
    private int index = 0;
    public float Time1 = 0f;
    public float Time2 = 0f;

    IEnumerator Start()
    {
        int max = NextCount < CurrentCount ? CurrentCount : NextCount;
        while (index < max)
        {
            yield return new WaitForSeconds(Time1);
            if (index < NextCount || index < CurrentCount)
            {
                if (index < NextCount) Next[index].SetActive(true);
                if (index < CurrentCount) Current[index].SetActive(false);
            }
            index++;
        }
        yield return new WaitForSeconds(Time2);
        for (int i = NextCount; i < Next.Length; i++) Next[i].SetActive(true);
        for (int i = CurrentCount; i < Current.Length; i++) Current[i].SetActive(false);
    }
}
