using UnityEngine;

public class Fruta : MonoBehaviour
{
    private Animator Suguru;
    [SerializeField] private float puntosRecolectados;
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
            puntos.Sumarpuntos(puntosRecolectados);
            Destroy(gameObject,0.55f);
        }
    }
}
