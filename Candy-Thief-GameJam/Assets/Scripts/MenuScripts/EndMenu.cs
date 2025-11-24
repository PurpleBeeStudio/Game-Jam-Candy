using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void ClickReplay()
    {
        SceneManager.LoadScene("Game");
    }

    public void ClickReturn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

