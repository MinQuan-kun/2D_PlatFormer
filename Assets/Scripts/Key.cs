using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Door.hasKey = true; 
            Debug.Log("Đã nhặt chìa khóa!");
            Destroy(gameObject);
        }
    }
}