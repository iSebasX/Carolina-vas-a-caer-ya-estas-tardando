using UnityEngine;
using UnityEngine.UI;

public class BarradeVida : MonoBehaviour
{
    [SerializeField] ControladorVida vida;
    [SerializeField] Image Barra;

    private void Start()
    {
        vida.OnVidaCambiada += ActualizarBarra;
        ActualizarBarra(vida.Vida);
    }

    public void ActualizarBarra(float nuevoValor)
    {
        Barra.fillAmount = nuevoValor / vida.VidaMaxima;
    }
}












