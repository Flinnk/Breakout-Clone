using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

    private GameObject ball;
    public Text scoreText;
    private int score;
    public Text livesText;
    private int lives;
    public static GameManager instance;
    public bool initialized = false;
    public int numberOfBricks = 0;

    void Awake()
    {
        instance = this;
        numberOfBricks = GameObject.FindGameObjectsWithTag("Brick").Length;
        ball = GameObject.FindGameObjectWithTag("Ball");
        UpdateScore(0);
        UpdateLives(3);
        initialized = true;
        
    }

    public void UpdateScore(int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
        numberOfBricks--;
        if (numberOfBricks <= 0)
        {
            Application.LoadLevel(2);
        }
    }

    public void UpdateLives(int lives)
    {
        this.lives += lives;
        livesText.text = "Lifes: " + this.lives.ToString();
        if (initialized)
        {
            if (this.lives > 0)
            {
                ResetBall();
            }
            else
            {
                GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>().SetScore(score);
                Application.LoadLevel(2);
            }
        }
    }

    private void ResetBall()
    {
        ball.GetComponent<Ball>().Reset();
    }
}
