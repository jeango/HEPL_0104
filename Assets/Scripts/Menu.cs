using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("Game");
        GameManager.NewGame();
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}
