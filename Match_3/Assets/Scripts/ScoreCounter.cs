using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    private int _score;
    private int _highscore;

    public int HighScore
    {
        get => _highscore;

        set
        {
            if (_highscore == value) return;

            _highscore = value;


            HighscoreText.SetText($"Hiscore: {_highscore}");
        }
    }

    public int Score
    {
        get => _score;

        set
        {
            if (_score == value) return;

            _score = value;

            scoreText.SetText($"Score = {_score}");

        }
    }

    void Update()
    {
        HighScore = Score;
        if (PlayerPrefs.GetInt("score") <= HighScore)
        {
            PlayerPrefs.SetInt("score", HighScore);
        }

        HighscoreText.SetText("HighScore: " + PlayerPrefs.GetInt("score").ToString());
    }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI HighscoreText;

    private void Awake()
    {
        Instance = this; 
    }
}
