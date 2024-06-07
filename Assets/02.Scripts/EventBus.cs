using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum EventType
{
    Start,
    Play,
    Pasue,
    Roll,
    GambleLegend,
    End
}

public static class EventBus
{
    private static readonly Dictionary<EventType, Action> eventTable = new();

    public static void SubEvent(EventType eventType, Action action)
    {
        if (!eventTable.ContainsKey(eventType))
        {
            eventTable.Add(eventType, action);
            return;
        }
        eventTable[eventType] += action;
    }

    public static void UnSubEvent(EventType eventType, Action action)
    {
        if (!eventTable.ContainsKey(eventType))
        {
            return;
        }
        eventTable[eventType] -= action;
    }

    public static void CallEvent(EventType eventType)
    {
        if (!eventTable.ContainsKey(eventType))
        {
            return;
        }
        eventTable[eventType]?.Invoke();
    }
}
