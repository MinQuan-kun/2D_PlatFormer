using UnityEngine;
using UnityEngine.UI;
public class LevelButton : MonoBehaviour
{
    public int Level;
    void Start()
    {
        Button btn = GetComponent<Button>();
        if(PlayerPrefs.GetInt("CurrentLevel") < Level)
        {
            btn.interactable = false;
        }
    }


}
