using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public enum GradeType
{
    Normal,
    UnCommon,
    Rare,
    Epic,
    Legend
}

[CreateAssetMenu(fileName = "GambleData", menuName = "GambleData", order = -1)]
public class GambleData : ScriptableObject
{
    public GradeData[] GradeDatas;
#if UNITY_EDITOR
    [SerializeField] private float debugTotalRate = 0;//����׿� ���� Ȯ��

    public void OnValidate()//������ ������ ����� �� ���� �� ����
    {
        if (GradeDatas == null)
        {
            return;
        }
        GradeDatas = GradeDatas.OrderBy((g) => g.Rate).ToArray();

        debugTotalRate = 0;
        foreach (var grade in GradeDatas)
        {
            debugTotalRate += grade.Rate;
        }
        if (debugTotalRate > 1)
        {
            Debug.LogError("over Range");
        }
    }
#endif
}

[Serializable]
public class GradeData
{
    public GradeType Grade;
    public float Rate;
}