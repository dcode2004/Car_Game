using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public Text highScoreText;
    public Text scoreText;

    public int score;
    public int highScore;

    public Score_Manager scoreManager;

    public GameObject gamePausePanel;
    public GameObject gamePauseButton;

    // Start is called before the first frame update
    void Start()
    {
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        score = scoreManager.score;

        highScoreText.text = "High Score : " + highScore.ToString();
        scoreText.text = "Your Score : " + score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void GamePause()
    {
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
        gamePauseButton.SetActive(false);
    }

    public void GameResume()
    {
        Time.timeScale = 1;
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }
}
