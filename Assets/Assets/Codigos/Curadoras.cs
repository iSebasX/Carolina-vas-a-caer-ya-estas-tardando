using UnityEngine;

public class Curadoras : MonoBehaviour
{
    private Animator Suguru;
    [SerializeField] private float curación;
    [SerializeField] private Puntos puntos;
    private void Update()
    {
        Suguru = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Suguru.SetTrigger("Touch");
        if (collision.CompareTag("Player"))
        { 
            Destroy(gameObject, 0.60f);
        }
    }
}
