using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool onPause = false;
    public GameObject MenuPause;

    // Update is called once per frame
    void Update()
    {
        mettreLaPause();
    }

    private void mettreLaPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (onPause)
            {
                ContinuerLeJeu();
            }
            else
            {
                PauseLeJeu();
            }
        }
    }

    public void PauseLeJeu()
    {
        MenuPause.SetActive(true);
        Time.timeScale = 0f;
        onPause = true;
    }

    private void ContinuerLeJeu()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1f;
        onPause = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
