using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGamble : MonoBehaviour, IVisitElement
{
    public void Accept(IVisit visitor)
    {
        visitor.Visit(this);
    }

    public void ShowText(GradeType grade)
    {
        Debug.Log(grade);
    }
}
