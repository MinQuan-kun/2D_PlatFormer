using UnityEngine;
using UnityEngine.UI; // Cần thư viện này để chỉnh nút
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public int levelReq;
    public string levelName;
    private Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);

        if (levelReq > levelReached)
        {
            myButton.interactable = false;
        }
        else
        {
            myButton.interactable = true; 
        }
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelName);
        Time.timeScale = 1f; 
    }
}