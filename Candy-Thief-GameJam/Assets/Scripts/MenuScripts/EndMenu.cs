using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    private void Start()
    {
        Cursor.visible = true;
    }
    public void ClickReplay()
    {
        SceneManager.LoadScene("Game");
    }

    public void ClickReturn()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

