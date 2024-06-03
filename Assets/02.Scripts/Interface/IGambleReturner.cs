using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGambleReturner//뽑기 결과를 반환하는 역할
{
    public GradeType GetGambleGrade(float seed);
}
