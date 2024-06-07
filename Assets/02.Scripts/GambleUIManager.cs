using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GambleUIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text rollCountHUD;

    private void Awake()
    {
        EventBus.SubEvent(EventType.GambleLegend, () => TitleText.Instance.Title("전설등급"));
        EventBus.SubEvent(EventType.Roll, UpdateHUD);
    }
    public void UpdateHUD()
    {
        rollCountHUD.text = $"RollCount : {GameManager.Instance.RollCount}";
    }

    private void OnDestroy()
    {
        EventBus.UnSubEvent(EventType.Roll, UpdateHUD);
    }
}
