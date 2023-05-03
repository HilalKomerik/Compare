using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private Transform clock;
    [SerializeField]
    private Transform clock1;
    [SerializeField]
    private Transform clock2;
    [SerializeField]
    private Transform frame1;
    [SerializeField]
    private Transform frame2;
    [SerializeField]
    private Transform button;
    void Start()
    {
        clock.transform.GetComponent<RectTransform>().DOLocalMoveX(85f, 1.5f).SetEase(Ease.OutBack);
        clock1.transform.GetComponent<RectTransform>().DOLocalMoveX(-60f, 1.5f).SetEase(Ease.OutBack);
        clock2.transform.GetComponent<RectTransform>().DOLocalMoveX(-75f, 1.5f).SetEase(Ease.OutBack);
        frame1.transform.GetComponent<RectTransform>().DOLocalMoveX(-70f, 1.5f).SetEase(Ease.OutBack);
        frame2.transform.GetComponent<RectTransform>().DOLocalMoveX(45f, 1.5f).SetEase(Ease.OutBack);
        button.transform.GetComponent<RectTransform>().DOLocalMoveY(12f, 1.5f).SetEase(Ease.OutBack);
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
