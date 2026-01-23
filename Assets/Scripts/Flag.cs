using UnityEngine;
using TMPro;
public class Flag : MonoBehaviour
{
    public GameObject winUI;
    public TextMeshProUGUI carrotText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!collision.CompareTag("Player")) return;

            Player player = collision.GetComponent<Player>();
            if (player == null) return;

            if (winUI != null)
                winUI.SetActive(true);
            if (carrotText != null)
                carrotText.text = "Carrots: " + player.carrots;
            Time.timeScale = 0f;
        }
    }
}
