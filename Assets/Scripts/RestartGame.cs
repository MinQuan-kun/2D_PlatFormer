using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void LoadCurrentScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
