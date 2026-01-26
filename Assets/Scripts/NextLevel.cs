using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;
    public int nextLevelValue;
    public void LoadNextScene()
    {
        PlayerPrefs.SetInt("CurrentLevel", nextLevelValue);
        Time.timeScale = 1f;
        SceneManager.LoadScene(nextLevelName);

    }
}
