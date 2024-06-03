using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGambleReturner
{
    public GradeType GetGambleGrade(float seed);
    public IGambleable GetGambleResult(GradeType grade);
}
