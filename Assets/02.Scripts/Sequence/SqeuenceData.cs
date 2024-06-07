using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[RequireComponent(typeof(SqeuenceEndData))]
public class SqeuenceData : MonoBehaviour
{
    public List<UnityEvent> SqeuenceDatas = new();

    private SqeuenceEndData sqeuenceEnd;

    private void Awake()
    {
        sqeuenceEnd = GetComponent<SqeuenceEndData>();
    }

    public void PlayEvent(Action OnEnd = null)
    {
        foreach (var item in SqeuenceDatas)
        {
            item?.Invoke();
        }
        sqeuenceEnd.OnEnd = OnEnd;
        sqeuenceEnd.PlayEnd();
    }
}
