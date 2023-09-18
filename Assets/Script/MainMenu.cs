using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad = "MainLevel";

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }


    public void HowToPlay()
    {
        SceneManager.LoadScene(3);
    }


    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
    public void Quit()
    {
        Debug.Log("Exciting...");
        Application.Quit();
    }

}