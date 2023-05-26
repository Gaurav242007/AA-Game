using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int PinCount;

    public TMP_Text text;
    public static int ScoreBooster;
    public TMP_Text hightScoreText;
    // if the game has never been played before
    // then the default state for hightScore equal --> 0
    public static int HightScore;
    public static AudioController AudioController;
    public AudioController audiocontroller;
    // both variable stores the max score for completing level
    public static int ScoreToCompleteLevel;
    public int MaxScoreToCompleteLevel;

    void Start()
    {
        // VERY IMPORTANT!!!
        // because after loading scene again the static
        // variables are not changeds
        PinCount = 0;
        ScoreBooster = 1;
        // if the game has never been played before
        // then the default state for hightScore equal --> 0
        HightScore = PlayerPrefs.GetInt("highScore", 0);
        AudioController = audiocontroller;
        ScoreToCompleteLevel = MaxScoreToCompleteLevel;
    }

    public static void IncreasePinCount()
    {
        if (PinCount > 0 && PinCount / 5 == 0)
        {
            ScoreBooster++;
            AudioController.PlayScoreBooster();
        }
        else if (PinCount >= ScoreToCompleteLevel)
        {
            GameManager.hasLevelCompleted = true;
        }
        PinCount += ScoreBooster;
        AudioController.PlayHitSfx();

        if (Score.PinCount > HightScore)
        {
            UpdateHighscore();
        }
    }

    public static void UpdateHighscore()
    {
        Debug.Log("Updated HighScore");
        PlayerPrefs.SetInt("highScore", Score.PinCount);
        HightScore = PlayerPrefs.GetInt("highScore", PinCount);
    }


    void Update()
    {
        text.text = PinCount.ToString();
        hightScoreText.text = "HighScore: " + HightScore.ToString();
    }
}
