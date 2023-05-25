using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    private int _score, _highscore;
    [SerializeField] private TMP_Text scoreText, highscoreText;

    private void Start()
    {
        Load();
        _score = 0;
        scoreText.text = "Score: " + 0;
        highscoreText.text = "Highscore: " + _highscore.ToString();

    }

    public void AddScore(int amount)
    {
        _score += amount;
        UpdateScoreText();
        Save();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + _score.ToString();

        if (_score > _highscore)
        {
            _highscore = _score;
            highscoreText.text = "Highscore: " + _highscore.ToString();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("_score", _score);
        PlayerPrefs.SetInt("_highscore", _highscore);
    }
    public void Load()
    {
        _score = PlayerPrefs.GetInt("_score");
        _highscore = PlayerPrefs.GetInt("_highscore");
    }
}
