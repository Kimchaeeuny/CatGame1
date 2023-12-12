using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isRunning;
    public GameObject popup;
    public GameObject GameStartpopup;
    private void Awake()
    {
        Instance = this;
        Time.timeScale = 0;
    }

    public void ReStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void GameStart()
    {
        GameStartpopup.SetActive(false);
        Time.timeScale = 1;
        isRunning = true;
    }
    public void GameOver()
    {
        popup.SetActive(true);
        Time.timeScale = 0;
        isRunning = false;
    }
}
