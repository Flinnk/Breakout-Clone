using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

    private int score = 0;
    static ScoreKeeper instance;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }
}
