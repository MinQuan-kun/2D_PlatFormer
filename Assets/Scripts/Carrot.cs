using UnityEngine;
using TMPro;
public class Carrot : MonoBehaviour
{
    public AudioClip collectClip;
    public TextMeshProUGUI carrotText;
    public float flySpeed = 2f;
    public float flyHeight = 0.25f;
    
    private Vector3 startPos;
    private float randomOffset;
    void Start()
    {
        startPos = transform.position;
        randomOffset = Random.Range(0f, 5f);
        carrotText = GameObject.FindWithTag("CarrotText").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin((Time.time + randomOffset) * flySpeed) * flyHeight;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            if(player != null)
            {
                player.carrots += 1;
                player.PlaySFX(collectClip, 0.4f);
                carrotText.text = player.carrots.ToString();
            }
            Destroy(gameObject);
        }
    }
}