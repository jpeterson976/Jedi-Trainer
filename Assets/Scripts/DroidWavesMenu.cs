using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroidWavesMenu : MonoBehaviour
{
    // retry this scene
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // return to main menu
    public void Return()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
