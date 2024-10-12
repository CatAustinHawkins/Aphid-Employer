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
        SceneManager.LoadScene("Gameplay");

    }

    public void GameEnd()
    {
        SceneManager.LoadScene("GameFinish");

    }

}
