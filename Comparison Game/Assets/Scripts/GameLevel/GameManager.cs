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
    private GameObject text,text1;

    [SerializeField]
    private GameObject topRectangle, lowerRectangle;

    [SerializeField]
    private Text topText, lowerText;

    TimerManager timerManager;
    CirclesManager circlesManager;
    TrueFalseManager trueFalseManager;

    int gameCounter, gameChallengesNumber;

    int topValue, bottomValue;

    int highestValue;

    int buttonValue;

    private void Awake()
    {
        timerManager = Object.FindObjectOfType<TimerManager>();
        circlesManager = Object.FindObjectOfType<CirclesManager>();
        trueFalseManager = Object.FindObjectOfType<TrueFalseManager>();
    }
    void Start()
    {
        gameChallengesNumber = 0;
        gameCounter = 0;

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

        StartGame(); // Deneme amaçlý kapattýk sonrdan aç

    }

    public void StartGame()
    {
        text.GetComponent<CanvasGroup>().DOFade(0, 1f);

        text1.GetComponent<CanvasGroup>().DOFade(1, 1f);



        GameDifficulty();

        //timerManager.StartTime();// Deneme amaçlý kapattýk sonrdan aç

    }

    void GameDifficulty()
    {
        if (gameCounter<5)
        {
            gameChallengesNumber = 1;
        }
        else if (gameCounter>=5&& gameCounter<10)
        {
            gameChallengesNumber = 2;
        }
        else if (gameCounter >= 10 && gameCounter < 15)
        {
            gameChallengesNumber = 3;
        }
        else if (gameCounter >= 15 && gameCounter < 20)
        {
            gameChallengesNumber = 4;
        }
        else if (gameCounter >= 20 && gameCounter < 25)
        {
            gameChallengesNumber = 5;
        }
        else
        {
            gameChallengesNumber = Random.Range(1, 6);
        }

        switch (gameChallengesNumber)
        {
            case 1 :
                FirstChallenge();
                break;
            case 2:
                SecondFunction();
                break;
            case 3:
                ThirdFunction();
                break;
            case 4:
                FourthFunction();
                break;
            case 5:
                FifthFunction();
                break;
        }
    }

    void FirstChallenge()
    {
        int randomValue = Random.Range(1, 50);

        if (randomValue<=25)
        {
            topValue = Random.Range(2, 50);
            bottomValue = topValue + Random.Range(1, 10);
        }else
        {

            topValue = Random.Range(2, 50);
            bottomValue =Mathf.Abs(topValue - Random.Range(1, 10)) ;
        }

        if (topValue>bottomValue)
        {
            highestValue = topValue;
        }
        else if(topValue<bottomValue)
        {
            highestValue = bottomValue;
        }

        if (topValue == bottomValue)
        {
            FirstChallenge();
            return;
        }

        topText.text = topValue.ToString();
        lowerText.text = bottomValue.ToString();
    }

    void SecondFunction()
    {
        int firstNumber = Random.Range(1, 10);
        int secondNumber = Random.Range(1, 20);

        int thirdNumber = Random.Range(1, 10);
        int fourthNumber = Random.Range(1, 20);

        topValue = firstNumber + secondNumber;
        bottomValue = thirdNumber + fourthNumber;

        if (topValue>bottomValue)
        {
            highestValue = topValue;
        }
        else if (topValue < bottomValue)
        {
            highestValue = bottomValue;
        }


        if (topValue == bottomValue)
        {
            SecondFunction();
            return;
        }

        topText.text = firstNumber + "  + " + secondNumber;
        lowerText.text = thirdNumber + "  + " + fourthNumber;
    }

    void ThirdFunction()
    {
        int firstNumber = Random.Range(11, 30);
        int secondNumber = Random.Range(1, 11);

        int thirdNumber = Random.Range(11, 40);
        int fourthNumber = Random.Range(1, 11);

        topValue = firstNumber - secondNumber;
        bottomValue = thirdNumber - fourthNumber;

        if (topValue > bottomValue)
        {
            highestValue = topValue;
        }
        else if (topValue < bottomValue)
        {
            highestValue = bottomValue;
        }


        if (topValue == bottomValue)
        {
            ThirdFunction();
            return;
        }

        topText.text = firstNumber + "  - " + secondNumber;
        lowerText.text = thirdNumber + "  - " + fourthNumber;
    }

    void FourthFunction()
    {
        int firstNumber = Random.Range(1, 10);
        int secondNumber = Random.Range(1, 10);

        int thirdNumber = Random.Range(1,10);
        int fourthNumber = Random.Range(1, 10);

        topValue = firstNumber * secondNumber;
        bottomValue = thirdNumber * fourthNumber;

        if (topValue > bottomValue)
        {
            highestValue = topValue;
        }
        else if (topValue < bottomValue)
        {
            highestValue = bottomValue;
        }


        if (topValue == bottomValue)
        {
            FourthFunction();
            return;
        }

        topText.text = firstNumber + "  x  " + secondNumber;
        lowerText.text = thirdNumber + "  x  " + fourthNumber;
    }

    void FifthFunction()
    {
        int dividing1 = Random.Range(2, 10); // Bölen
        topValue = Random.Range(2, 10);

        int devidend1 = dividing1 * topValue;  // Bölünen


        int dividing2 = Random.Range(2, 10); 
        bottomValue = Random.Range(2, 10);

        int devidend2 = dividing1 * topValue;

        if (topValue > bottomValue)
        {
            highestValue = topValue;
        }
        else if (topValue < bottomValue)
        {
            highestValue = bottomValue;
        }


        if (topValue == bottomValue)
        {
            FifthFunction();
            return;
        }

        topText.text = devidend1 + "  /  " + dividing1;
        lowerText.text = devidend2 + "  x  " + dividing2;
    }

    public void EvaluateButtonValue(string buttonName)
    {
        if (buttonName == "topRectangle")
        {
            buttonValue = topValue;

        }
        else if (buttonName == "lowerRectangle")
        {
            buttonValue = bottomValue;
        }

        if (buttonValue == highestValue)
        {
            trueFalseManager.TrueFalseScaleOpen(true);

            circlesManager.CircleScaleOpen(gameCounter % 5); // 5 daire olduðu için 5 mod aldýk.
            gameCounter++;

            GameDifficulty();
        }
        else
        {
            trueFalseManager.TrueFalseScaleOpen(false);
            ErrorCounterReduction();
            GameDifficulty();
        }
    }

    void ErrorCounterReduction()
    {
        gameCounter -= (gameCounter % 5 + 5);

        if (gameCounter<0)
        {
            gameCounter = 0; 
        }

        circlesManager.CircleScaleClose();
    }


}
