using UnityEngine;

public class ControladorEnemigo : MonoBehaviour
{
    [SerializeField] ControladorVida vida;
    [SerializeField] controladorEnemigos movimientos;

    private void OnEnable() //Se ejecuta cada que un objeto en la escena se activa
    {
        vida.muerte += Muelto; 
    }
    private void Muelto(float nuevoValor)
    {
        movimientos.anim.SetBool("Muerte", true);
        movimientos.DesactivarMovimiento();
    }

    public void Destruir() 
    {
        Destroy(gameObject);
    }

}
