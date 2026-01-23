using UnityEngine;

public class Carrot : MonoBehaviour
{
    public AudioClip collectClip;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.carrots += 1;
            Destroy(gameObject);
            player.PlaySFX(collectClip, 0.4f);
        }
    }

}
