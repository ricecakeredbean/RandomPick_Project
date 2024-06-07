using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisit//구체화
{
    public void Visit(IVisitElement element);
}

public interface IVisitElement//넘겨주는 놈
{
    public void Accept(IVisit visitor);
}

