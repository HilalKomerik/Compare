using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pointDurationPanel;

    [SerializeField]
    private GameObject text;

    [SerializeField]
    private GameObject topRectangle;

    [SerializeField]
    private GameObject lowerRectangle;
    void Start()
    {
        UpdateStageScreen();
    }

    void UpdateStageScreen()
    {
        pointDurationPanel.GetComponent<CanvasGroup>().DOFade(1, 1f);
        text.GetComponent<CanvasGroup>().DOFade(1, 1f);

        topRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);
        lowerRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);
    }

}
