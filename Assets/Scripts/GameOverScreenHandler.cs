using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScreenHandler : MonoBehaviour {

    public Text score;
	void Start () 
    {
        score.text = "Your score: " + GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreKeeper>().GetScore().ToString();
	}
	
}
