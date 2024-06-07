using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GambleSystem : MonoBehaviour, IVisit
{
    [SerializeField] private GambleData fruitGambleData;
    [SerializeField] private GambleData coinGambleData;

    public GradeType GetGambleGrade(float seed, GambleData gamble)
    {
        EventBus.CallEvent(EventType.Roll);
        float currentRate = 0;//���� �˻����� ����
        foreach (var gradeData in gamble.GradeDatas)
        {
            currentRate += gradeData.Rate;//Ȯ����ŭ ������ ������(25%�� ~25���� �˻� ���� 50%�� Ȯ���� ���� ��ü�� ������ ~75���� �˻��ϴ� ��)
            if (currentRate >= seed)//���� �ȿ� ����������
            {
                if (gradeData.Grade == GradeType.Legend)
                {
                    EventBus.CallEvent(EventType.GambleLegend);
                }
                return gradeData.Grade;//�ش� ����� ��ȯ
            }
        }
        return default;//Ȯ���� ������ �־� �˻簡 ����� ������� ���� ��� �⺻���� ��ȯ
    }

    public void Visit(IVisitElement element)
    {
        Debug.Log("ȣȯ�ȵ�");
    }

    public void Visit(FruitGamble fruitGamble)
    {
        fruitGamble.ShowText(GetGambleGrade(Random.value, fruitGambleData));
    }
}
