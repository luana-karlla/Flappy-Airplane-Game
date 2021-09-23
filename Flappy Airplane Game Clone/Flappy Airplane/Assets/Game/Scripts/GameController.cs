using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text txtScore;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1; 
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitPlayer()
    {
        Application.Quit();
    }
}
