using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class SqeuenceController : MonoBehaviour
{
    public List<SqeuenceData> sqeuenceDatas = new();

    private int currentIndex = 0;

    public void PlaySqeuence(Action OnEnd = null)
    {
        foreach (var item in sqeuenceDatas)
        {
            item.PlayEvent(() =>
            {
                currentIndex++;
                if (!EndCheck())
                {
                    return;
                }
                OnEnd?.Invoke();
            });
        }
    }

    private bool EndCheck()
    {
        return currentIndex >= sqeuenceDatas.Count;
    }
}


