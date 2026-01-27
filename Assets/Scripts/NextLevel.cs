using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;
    public int nextLevelValue;
    public void LoadNextScene()
    {
        PlayerPrefs.SetInt("LevelReached", nextLevelValue);
        SceneManager.LoadScene(nextLevelName);
        Time.timeScale = 1f;
    }
}
