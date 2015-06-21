using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(int number)
    {
        Application.LoadLevel(number);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
