using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ClickPlay()
    {
        SceneManager.LoadScene("Main");
    }

    public void ClickExit()
    {
        Debug.Log("Exiting...");
        Application.Quit();
    }
}

