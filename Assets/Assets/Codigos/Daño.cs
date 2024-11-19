using UnityEngine;

public class Daño : MonoBehaviour
{
    [SerializeField] float DMG;
    Collider2D colador;

    private void Start()
    {
        colador = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorVida>())
        {
            ControladorVida vidapnj;
            if (collision.gameObject.TryGetComponent(out vidapnj))
            {
                vidapnj.RecibirDaño(DMG);
            }
        }
    }

    public void EnableCollitions () 
    {
        colador.enabled = true;
    }
    public void DisableCollitions()
    {
        colador.enabled = false;
    }
}