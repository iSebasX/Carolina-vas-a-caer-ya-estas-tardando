using UnityEngine;

public class PuntosPiedras : MonoBehaviour
{
    [SerializeField] float Velocidad;
    [SerializeField] float tiempoDeEspera;
    [SerializeField] Transform[] puntosDeMovimiento;
    [SerializeField] float tiempoDeEsperaInicial;
    private int i = 0;
    void Start()
    {
        tiempoDeEspera = tiempoDeEsperaInicial;
    }


    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosDeMovimiento[i].transform.position, Velocidad * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntosDeMovimiento[i].transform.position) < 0.1f)
        {
            if (tiempoDeEspera <= 0)
            {
                if (puntosDeMovimiento[i] != puntosDeMovimiento[puntosDeMovimiento.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                tiempoDeEspera = tiempoDeEsperaInicial;
            }
            else
            {
                tiempoDeEspera -= Time.deltaTime;
            }
        }
    }
}
