using UnityEngine;

public class ControladorVida : MonoBehaviour
{
    public delegate void VidaActualizadaDelegado(float nuevoValor);
    public VidaActualizadaDelegado muerte;
    public VidaActualizadaDelegado recibioDaño;
    public VidaActualizadaDelegado recibioCura;

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
        recibioDaño?.Invoke(vida);
        if (vida <= 0)
        {
            muerte?.Invoke(vida);
            vida = 0;
            Destroy(gameObject);
        }
    }

    public void RecibirCura(float cura)
    {
        vida += cura;
        recibioCura?.Invoke(vida);
        if (vida >= vidaMaxima)
        { 
            vida = vidaMaxima;
        }
        OnVidaCambiada?.Invoke(vida);
    }
}
