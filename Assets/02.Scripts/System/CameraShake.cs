using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakePower;

    private Coroutine ShakeCoroutine;

    private Vector2 originPos;

    private void Awake()
    {
        originPos = transform.position;
    }

    public void ShakeCamera()
    {
        if (ShakeCoroutine != null)
        {
            StopCoroutine(ShakeCoroutine);
        }
        ShakeCoroutine = StartCoroutine(PlayShake());
    }

    private IEnumerator PlayShake()
    {
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime * 2.5f;
            Vector3 shakeDir = originPos + Random.insideUnitCircle * shakePower;
            shakeDir.z = -10;
            transform.position = shakeDir;
            yield return null;
        }
    }
}
