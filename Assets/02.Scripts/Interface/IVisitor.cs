using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisit//��üȭ
{
    public void Visit(IVisitElement element);
}

public interface IVisitElement//�Ѱ��ִ� ��
{
    public void Accept(IVisit visitor);
}

