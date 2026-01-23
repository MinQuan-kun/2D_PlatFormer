using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string nextLevelName;

    public void LoadNextScene()
    {
        Time.timeScale = 1f;

        if (!string.IsNullOrEmpty(nextLevelName))
        {
            SceneManager.LoadScene(nextLevelName);
        }
        else
        {
            Debug.LogError("❌ nextLevelName chưa được nhập trong Inspector");
        }
    }
}
