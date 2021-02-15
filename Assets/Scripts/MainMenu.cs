﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartTrainingMode()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void StartBattleMode()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
