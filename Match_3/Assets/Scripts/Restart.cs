using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}