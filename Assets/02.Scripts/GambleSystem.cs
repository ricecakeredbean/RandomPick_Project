using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GambleSystem : MonoBehaviour, IGambleReturner
{
    [SerializeField] private GambleData gamble;

    [ContextMenu("StartGamble")]
    public void GambleStart()
    {
        Debug.Log(GetGambleGrade(Random.value));
    }

    public GradeType GetGambleGrade(float seed)
    {
        float currentRate = 0;
        foreach (var gradeData in gamble.GradeDatas)
        {
            currentRate += gradeData.Rate;
            if (currentRate > seed)
            {
                return gradeData.Grade;
            }
        }
        return default;
    }

    public IGambleable GetGambleResult(GradeType grade)
    {
        switch (grade)
        {
            case GradeType.Normal:
                break;
            case GradeType.UnCommon:
                break;
            case GradeType.Rare:
                break;
            case GradeType.Epic:
                break;
            case GradeType.Legend:
                break;
            default:
                break;
        }
        return default;
    }
}
