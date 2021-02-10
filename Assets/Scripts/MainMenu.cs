﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartTrainingMode()
    {
        SceneManager.LoadScene(1);
    }

    public void StartBattleMode()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Debug.Log("Quit button works! :D");
        Application.Quit();
    }
}