using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleText : Singleton<TitleText>
{
    [SerializeField] private Text titleText;
    [SerializeField] private GameObject titleObject;

    protected override void Awake()
    {
        base.Awake();
        EventBus.SubEvent(EventType.Start, () => Title("게임 시작"));
        EventBus.SubEvent(EventType.GambleLegend, () => Title("전설등급"));
    }

    public void Title(string text)
    {
        titleText.text = text;
        titleObject.SetActive(false);
        titleObject.SetActive(true);
    }

    private void OnDestroy()
    {
        EventBus.UnSubEvent(EventType.Start, () => Title("게임 시작"));
        EventBus.UnSubEvent(EventType.GambleLegend, () => Title("전설등급"));
    }
}
