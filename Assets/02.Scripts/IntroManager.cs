using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public SqeuenceController sqeuenceController;

    public Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartButton);
    }

    private void StartButton()
    {
        PlaySqueence();
    }

    private void PlaySqueence()
    {
        sqeuenceController.PlaySqeuence(() => SceneLoadSystem.LoadScene("Main"));
    }
}
