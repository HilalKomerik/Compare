using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    [SerializeField]
    private Text trueText, falseText, ScoreText;


    int scoreTime = 10;
    bool timeOver = true;

    int totalScore, postedScore, increasingScore;


    private void Awake()
    {
        timeOver = true;
    } 

    public void Results(int trueNumber, int falseNumber, int scoreText)
    {
        trueText.text = trueNumber.ToString();
        falseText.text = falseNumber.ToString();
        ScoreText.text = scoreText.ToString();

        totalScore = scoreText;

        increasingScore = totalScore / 10;


        StartCoroutine(PrintScoreRoutine());
    }

    IEnumerator PrintScoreRoutine()
    {
        while (timeOver)
        {
            yield return new WaitForSeconds(0.1f);

            postedScore += increasingScore;

            if (postedScore>= totalScore)
            {
                postedScore = totalScore;
            }

            ScoreText.text = postedScore.ToString();

            if (scoreTime<=0)
            {
                timeOver = false;
            }

            scoreTime--;
        }
    }


    public void MainMenu()
    {
        SceneManager.LoadScene("ManuLevel");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameLevel");
    }

}
