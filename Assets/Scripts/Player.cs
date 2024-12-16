using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnDestroy()
    {
        GameManager.GameOver();
        SceneManager.LoadScene("GameOver",LoadSceneMode.Additive);
    }
}
