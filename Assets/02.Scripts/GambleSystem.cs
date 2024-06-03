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
        float currentRate = 0;//���� �˻����� ����
        foreach (var gradeData in gamble.GradeDatas)
        {
            currentRate += gradeData.Rate;//Ȯ����ŭ ������ ������(25%�� ~25���� �˻� ���� 50%�� Ȯ���� ���� ��ü�� ������ ~75���� �˻��ϴ� ��)
            if (currentRate >= seed)//���� �ȿ� ����������
            {
                return gradeData.Grade;//�ش� ����� ��ȯ
            }
        }
        return default;//Ȯ���� ������ �־� �˻簡 ����� ������� ���� ��� �⺻���� ��ȯ
    }
}
