using UnityEngine;

public class Girar180 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.Rotate(0, 180, 0);
        }
    }
}
