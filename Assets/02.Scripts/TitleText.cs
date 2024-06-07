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
        EventBus.SubEvent(EventType.Start, () => Title("���� ����"));
        EventBus.SubEvent(EventType.GambleLegend, () => Title("�������"));
    }

    public void Title(string text)
    {
        titleText.text = text;
        titleObject.SetActive(false);
        titleObject.SetActive(true);
    }

    private void OnDestroy()
    {
        EventBus.UnSubEvent(EventType.Start, () => Title("���� ����"));
        EventBus.UnSubEvent(EventType.GambleLegend, () => Title("�������"));
    }
}
