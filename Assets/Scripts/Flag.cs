using UnityEngine;
using TMPro; // Thư viện TextMeshPro

public class Flag : MonoBehaviour
{
    public GameObject winUI;
    public TextMeshProUGUI finalScoreText;
    private int totalCarrots;

    void Start()
    {
        totalCarrots = FindObjectsOfType<Carrot>().Length;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            
            if (player != null)
            {
                if (winUI != null)
                    winUI.SetActive(true);

                if (finalScoreText != null)
                {
                    finalScoreText.text = player.carrots.ToString() + " / " + totalCarrots.ToString();
                }

                // 3. Dừng game
                Time.timeScale = 0f;
            }
        }
    }
}