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
        float currentRate = 0;//현재 검사중인 범위
        foreach (var gradeData in gamble.GradeDatas)
        {
            currentRate += gradeData.Rate;//확률만큼 범위에 더해줌(25%면 ~25까지 검사 그후 50%의 확률을 가진 객체가 있으면 ~75까지 검사하는 식)
            if (currentRate >= seed)//범위 안에 속해있으면
            {
                return gradeData.Grade;//해당 등급을 반환
            }
        }
        return default;//확률에 문제가 있어 검사가 제대로 진행되지 못한 경우 기본값을 반환
    }
}
