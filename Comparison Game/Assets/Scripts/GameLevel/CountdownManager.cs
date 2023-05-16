using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CountdownManager : MonoBehaviour
{
    [SerializeField]
    private GameObject countdownObject;

    [SerializeField]
    private Text countdownText;

    GameManager gameManager;

    [SerializeField]
    private AudioClip dene1, dene2, dene3;
    private AudioSource audioSource;

    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        audioSource = Object.FindObjectOfType<AudioSource>();
    }
    void Start()
    {
       StartCoroutine(CountdownRoutine());
    }
    IEnumerator CountdownRoutine()
    {
        
        countdownText.text = "3";
        yield return new WaitForSeconds(0.5f);
        audioSource.PlayOneShot(dene1);
        countdownObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        
        countdownObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        
        countdownText.text = "2";
        yield return new WaitForSeconds(0.5f);
        audioSource.PlayOneShot(dene2);
        countdownObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        
        countdownObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        
        countdownText.text = "1";
        yield return new WaitForSeconds(0.5f);
        audioSource.PlayOneShot(dene3);
        countdownObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        
        countdownObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        StopAllCoroutines();

        gameManager.StartGame();
    }

}
