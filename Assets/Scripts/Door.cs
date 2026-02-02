using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 

public class Door : MonoBehaviour
{
    public static bool hasKey = false;
    public Sprite openDoorSprite;      
    private SpriteRenderer spriteRenderer;
    public bool isOpen = false; 

    [Header("Win UI Settings")]
    public GameObject winUI;
    public TextMeshProUGUI finalScoreText;
    private int totalCarrots;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        hasKey = false;
        isOpen = false;

        totalCarrots = FindObjectsOfType<Carrot>().Length;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Nếu có chìa khóa và cửa chưa mở -> Mở cửa
            if (hasKey && !isOpen)
            {
                OpenDoor();
            }
            // Nếu cửa đã mở -> Thực hiện cơ chế qua màn (giống Flag)
            else if (isOpen)
            {
                ShowWinUI(other.GetComponent<Player>());
            }
            else
            {
                Debug.Log("Bạn cần tìm chìa khóa!");
            }
        }
    }

    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            if (openDoorSprite != null)
                spriteRenderer.sprite = openDoorSprite;
            Debug.Log("Cửa đã mở!");
        }
    }

    // 4. Hàm hiển thị UI chiến thắng (Code lấy từ Flag.cs sang)
    void ShowWinUI(Player player)
    {
        if (player != null)
        {
            // Bật bảng Win UI
            if (winUI != null)
                winUI.SetActive(true);

            // Cập nhật điểm số (Số cà rốt ăn được / Tổng số)
            if (finalScoreText != null)
            {
                finalScoreText.text = player.carrots.ToString() + " / " + totalCarrots.ToString();
            }

            // Dừng game lại
            Time.timeScale = 0f;
            
            Debug.Log("Hoàn thành màn chơi!");
        }
    }
}