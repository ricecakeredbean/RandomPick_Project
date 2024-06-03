using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using Random = UnityEngine.Random;

public enum GradeType
{
    Normal,
    Rare,
    Epic,
    Legend
}

[CreateAssetMenu(fileName = "PickData", menuName = "PickData", order = -1)]
public class PickData : ScriptableObject
{
    [SerializeField] private GradeData[] gradeDatas;

    public void OnValidate()
    {
        int length = Enum.GetValues(typeof(GradeType)).Length;
        gradeDatas = new GradeData[];
        foreach (GradeType type in Enum.GetValues(typeof(GradeType)))
        {
            GradeData data = new GradeData(type);
            gradeDatas.Add(data);
        }
    }
}


[Serializable]
public class GradeData
{
    public UnityAction SelectAction;

    [Range(0.0f, 1.0f)]
    public float Rate;

    private GradeType grade;
    public GradeType debugType;

    public GradeData(GradeType grade)
    {
        this.grade = grade;
        debugType = grade;
    }

    public GradeType GetGradeType()
    {
        return grade;
    }
}