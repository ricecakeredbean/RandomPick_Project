using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGambleReturner//�̱� ����� ��ȯ�ϴ� ����
{
    public GradeType GetGambleGrade(float seed);
}
