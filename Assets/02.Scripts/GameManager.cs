using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int Coin;

    public int RollCount { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        EventBus.SubEvent(EventType.Roll, () => RollCount++);
    }

    private void Start()
    {
        EventBus.CallEvent(EventType.Start);
    }

    public void VisitorVisit(IVisit visitor, params IVisitElement[] elements)
    {
        foreach (var element in elements)
        {
            visitor.Visit(element);
        }
    }

    private void OnDestroy()
    {
        EventBus.UnSubEvent(EventType.Roll, () => RollCount++);
    }
}
