using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DroidWavesMenu : MonoBehaviour
{
    // retry this scene
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // return to main menu
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
