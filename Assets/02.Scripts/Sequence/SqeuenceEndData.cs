using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SqeuenceEndData : MonoBehaviour
{
    public float endTime;

    public Action OnEnd;

    public void PlayEnd()
    {
        StartCoroutine(EndTimer(endTime));
    }

    private IEnumerator EndTimer(float time)
    {
        yield return new WaitForSeconds(time);
        OnEnd?.Invoke();
    }
}
