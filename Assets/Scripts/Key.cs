using UnityEngine;

public class Key : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Door.hasKey = true; 
            
            Door door = FindFirstObjectByType<Door>(); 
            if (door != null)
            {
                door.OpenDoor();
            }

            Debug.Log("Đã nhặt chìa khóa!");
            Destroy(gameObject);
        }
    }
}