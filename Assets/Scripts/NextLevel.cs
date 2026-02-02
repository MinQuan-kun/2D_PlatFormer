using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;
    public int nextLevelValue; 

    public void LoadNextScene()
    {
        int currentLevelReached = PlayerPrefs.GetInt("LevelReached", 1);
        
        if (nextLevelValue > currentLevelReached)
        {
            PlayerPrefs.SetInt("LevelReached", nextLevelValue);
            PlayerPrefs.Save();
        }

        SceneManager.LoadScene(nextLevelName);
        Time.timeScale = 1f;
    }
}