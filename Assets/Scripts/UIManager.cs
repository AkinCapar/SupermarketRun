using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroupFail;
    [SerializeField] CanvasGroup canvasGroupWon;
    private Tween fadeTween;
    [SerializeField] GameObject MainUI;
    [SerializeField] GameObject InGameUI;
    [SerializeField] GameObject FailUI;
    [SerializeField] GameObject WinUI;

    void Start()
    {
        // StartCoroutine(TestFade());
    }

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


        // x(0f,6f, "sadas", () =>{
        //     Debug.Log("sdds")
        // });



        // var val1 = 0f;
        // var val2 = 6f;
        // var str1 = "sadas";

        // x(val1, val2, str1, SampleFunc);
    }

    // void SampleFunc()
    // {
    //      Debug.Log("sdds")
    // }

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
        MainUI.SetActive(false);
        InGameUI.SetActive(true);
    }

    public void LevelFail()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            FailUI.SetActive(true);
            FadeIn(0.5f, canvasGroupFail);
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

    // private IEnumerator TestFade()
    // {
    //     yield return new WaitForSeconds(2f);
    //     FadeOut(0.5f);
    //     yield return new WaitForSeconds(2f);
    //     FadeIn(0.5f, canvasGroup);
    // }
}