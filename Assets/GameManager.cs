using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCavas;

    public void GameOver()
    {
        gameOverCavas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Start()
    {
        Time.timeScale = 1;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
