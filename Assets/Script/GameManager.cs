using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [Header("Player 1")]
    [SerializeField] Controller P1;
    [SerializeField] TextMeshProUGUI P1Text;
    int P1Score;

    [Header("Player 2")]
    [SerializeField] Controller P2;
    [SerializeField] TextMeshProUGUI P2Text;
    int P2Score;

    [Header("Ball")]
    [SerializeField] Ball ball;

    [Header("UI & GameObjects")]
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject restartButton;
    [SerializeField] TextMeshProUGUI winText;
    [SerializeField] GameObject winScreen;
    [SerializeField] GameObject P1Controller;
    [SerializeField] GameObject P2Controller;
    [SerializeField] GameObject longMidPoint;

    void Awake()
    {
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        RestartGame();
        playButton.SetActive(false);
        P1Controller.SetActive(false);
        P2Controller.SetActive(false);
        longMidPoint.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartButton()
    {
        P1Score = 0;
        P1Text.text = P1Score.ToString();
        P2Score = 0;
        P2Text.text = P2Score.ToString();
        restartButton.SetActive(false);
        winScreen.SetActive(false);
        Time.timeScale = 1;
    }

    public void P1Scores()
    {
        P1Score++;
        P1Text.text = P1Score.ToString();
        RestartGame();
        FinnsihGame();
    }

    public void P2Scores()
    {
        P2Score++;
        P2Text.text = P2Score.ToString();
        RestartGame();
        FinnsihGame();
    }

    void RestartGame()
    {
        P1.Reset();
        P2.Reset();
        ball.Reset();
    }

    void FinnsihGame()
    {
        if (P1Score == 10)
        {
            winScreen.SetActive(true);
            restartButton.SetActive(true);
            winText.text = "Player One Wins";
            Time.timeScale = 0;
        }

        else if (P2Score == 10)
        {
            winScreen.SetActive(true);
            restartButton.SetActive(true);
            winText.text = "Player Two Wins";
            Time.timeScale = 0;
        }
    }
}
