using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] float DMG;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorVida>())
        {
            collision.gameObject.GetComponent<ControladorVida>().RecibirDaño(DMG);
        }
    }
}