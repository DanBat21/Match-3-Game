using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject quitPanel;
    public GameObject recordPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene("Scene_1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void QuitPanel()
    {
        quitPanel.SetActive(true);
    }

    public void RecordPanel()
    {
        recordPanel.SetActive(true);
    }

    public void Exit()
    {
        recordPanel.SetActive(false);
        quitPanel.SetActive(false);
    }

}
