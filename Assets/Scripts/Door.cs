using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public static bool hasKey = false;
    public Sprite openDoorSprite;      
    private SpriteRenderer spriteRenderer;
    private bool isOpen = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hasKey = false; 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Nhan vat da cham vao cua!");
            if (hasKey && !isOpen)
            {
                OpenDoor();
            }
            else if (isOpen)
            {
                NextLevel();
            }
            else
            {
                Debug.Log("Bạn cần tìm chìa khóa!");
            }
        }
    }

    void OpenDoor()
    {
        isOpen = true;
        spriteRenderer.sprite = openDoorSprite;
        Debug.Log("Cửa đã mở!");
    }

    void NextLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}