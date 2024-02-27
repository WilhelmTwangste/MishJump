using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public Text HighScoreText;
    [SerializeField] public Text TextScore;
  
    public static int score = 0;
    public static int score1;
    int highscore;
    public static int highscore1;
    public static int scoreEnd;

    void Start()
    {
        score = 0;
    }

    public void Update()
    {
        highscore = score;
        highscore1 = score;
        scoreEnd = score;
        TextScore.text = "—чет: " + highscore.ToString();
        if (PlayerPrefs.GetInt("score") <= highscore)
        {
            PlayerPrefs.SetInt("score", highscore);
        }
        HighScoreText.text = "–екорд: " + PlayerPrefs.GetInt("score").ToString();
        PlayerPrefs.SetInt("scoreEnd", scoreEnd);
        PlayerPrefs.SetInt("highscore1", highscore1);
        scoreEnd = score;
        highscore1 = highscore;
    }
}