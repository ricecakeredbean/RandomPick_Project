using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public enum GradeType//등급표
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
    [SerializeField] private float debugTotalRate = 0;//디버그용 총합 확률

    public void OnValidate()//수정될 때마다 디버그 값 변경 및 정렬
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
        if (debugTotalRate > 1)//확률은 1까지 설정 가능한데 확률의 총합이 1을 넘으면
        {
            Debug.LogError("over Range");//경고메시지 출력
        }
    }
#endif
}

[Serializable]
public struct GradeData//등급에 따른 확률을 저장하기 위한 클래스
{
    public GradeType Grade;
    public float Rate;
}