using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainerMenu : MonoBehaviour
{
    // retry this scene
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    // return to main menu
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
