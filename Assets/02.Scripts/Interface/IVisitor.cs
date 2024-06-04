using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisitor
{
    public void Visit(IElement element);
}

public interface IElement
{
    public void Accept(IVisitor visitor);
}

