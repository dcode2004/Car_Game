using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Manager : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public static int lastScore = 0;

    public Text scoreText;
    public Text highScoreText;
    public Text lastScoreText;

    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("high_score", 0);

        highScoreText.text = "HighScore : " + highScore.ToString();
        lastScoreText.text = "LastScore : " + lastScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreUpdate();
        highScoreUpdate();
    }

    void scoreUpdate()
    {
        if (timer < 2)
            timer += Time.deltaTime;
        else
        {
            score++;
            timer = 0;
        }

        lastScore = score;
        scoreText.text = score.ToString();
    }

    void highScoreUpdate()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("high_score", highScore);
        }
    }
}
