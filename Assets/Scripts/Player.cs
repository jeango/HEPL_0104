using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void OnDestroy()
    {
        SceneManager.LoadScene("GameOver",LoadSceneMode.Additive);
    }
}
