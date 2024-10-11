using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menus : MonoBehaviour
{

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenIntro()
    {
        SceneManager.LoadScene("Intro");

    }

    public void OpenTutorial()
    {
        SceneManager.LoadScene("Tutorial");

    }

    public void OpenGame()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void GameEnd()
    {
        SceneManager.LoadScene("GameFinish");

    }

}
