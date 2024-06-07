using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGamble : MonoBehaviour, IVisitElement
{
    public void Accept(IVisit visitor)
    {
        visitor.Visit(this);
    }

    public void GetCoin(GradeType grade)
    {
        GameManager.Instance.Coin += (int)grade + 1;
    }
}
