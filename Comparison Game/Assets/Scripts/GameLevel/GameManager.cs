using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pointDurationPanel;

    [SerializeField]
    private GameObject text;

    [SerializeField]
    private GameObject topRectangle, lowerRectangle;

    [SerializeField]
    private Text topText, lowerText;

    TimerManager timerManager;

    private void Awake()
    {
        timerManager = Object.FindObjectOfType<TimerManager>();
    }
    void Start()
    {
        topText.text = "";
        lowerText.text = "";

        UpdateStageScreen();
    }

    void UpdateStageScreen()
    {
        pointDurationPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        text.GetComponent<CanvasGroup>().DOFade(1, 1f);

        topRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);
        lowerRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);
    }

    public void StartGame()
    {
        text.GetComponent<CanvasGroup>().DOFade(0, 2f);

        topText.text = "(35+23)-20";
        lowerText.text = "(35+23)-20";

        timerManager.StartTime();

        Debug.Log("OYUN BAÞLADI");
    }
}
