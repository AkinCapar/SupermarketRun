using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroupFail;
    [SerializeField] CanvasGroup canvasGroupWon;
    [SerializeField] CanvasGroup canvasGroupMainUI;
    private Tween fadeTween;
    [SerializeField] GameObject MainUI;
    [SerializeField] GameObject InGameUI;
    [SerializeField] GameObject FailUI;
    [SerializeField] GameObject WinUI;


    void Update()
    {
        LevelWon();
        LevelFail();
    }

    public void FadeIn(float duration, CanvasGroup canvasGroup)
    {
        Fade(1f, duration, () =>
        {
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
        }, canvasGroup);
    }

    public void FadeOut(float duration, CanvasGroup canvasGroup)
    {
        Fade(0f, duration, () => { canvasGroup.interactable = false; canvasGroup.blocksRaycasts = false;}, canvasGroup);
    }

    private void Fade(float endValue, float duration, TweenCallback onEnd, CanvasGroup canvasGroup)
    {
        if (fadeTween != null)
        {
            fadeTween.Kill(false);
        }
        fadeTween = canvasGroup.DOFade(endValue, duration);
        fadeTween.onComplete += onEnd;
    }

    public void StartGameButton()
    {
        // MainUI.SetActive(false);
        FadeOut(0.5f, canvasGroupMainUI);
        InGameUI.SetActive(true);
    }

    public void LevelFail()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FailUI.SetActive(true);
            FadeIn(0.25f, canvasGroupFail);
        }
    }

    public void LevelWon()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            WinUI.SetActive(true);
            FadeIn(0.5f, canvasGroupWon);
        }
    }

    public void NextLevelButton()
    {

    }

    public void TryAgainButton()
    {
        
    }
}