using UnityEditor.SearchService;
using UnityEngine;

public class ControladorVida : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float vidaMaxima;

    public float Vida
    {
        get {return vida;}
        set {vida = value;}
    }

    public float VidaMaxima
    {
        get { return vidaMaxima; }
        set { vidaMaxima = value; }
    }

    public delegate void VidaCambiada(float nuevoValor);
    public event VidaCambiada OnVidaCambiada;

    public void RecibirDaño(float daño)
    {
        vida -= daño;
        OnVidaCambiada?.Invoke(vida);
        if (vida <= 0)
        {
            Debug.Log("Muerto");
            Destroy(gameObject);
        }
    }

    public void RecibirCura(float cura)
    {
        vida += cura;
        if (vida >= vidaMaxima)
        {
            vida = vidaMaxima;
        }
        OnVidaCambiada?.Invoke(vida);
    }
}
