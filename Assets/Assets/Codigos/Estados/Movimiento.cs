using UnityEngine;

public class MovimientoStates : MonoBehaviour
{
    public Animator dongojo;
    public Rigidbody2D rigid;

    Basestate estadoActual;
    
    EstadoIdle idle; 
    EstadoCorrer correr; 
    EstadoSalto salto; 
    EstadoCaida caida;
    EstadoSaltoDoble saltoDoble;
    EstadoSaltoPared saltoPared;

    public float velodidad;

    void Start()
    {
        dongojo = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

        idle = new EstadoIdle(this); //"this" pasará toda la instancia en la que se encuentre 
        correr = new EstadoCorrer(this);
        salto = new EstadoSalto(this);
        caida = new EstadoCaida(this);
        saltoDoble = new EstadoSaltoDoble(this);    
        saltoPared = new EstadoSaltoPared(this);

        CambiarEstado(idle);
    }
    void Update()
    {
        
    }

    public void CambiarEstado (Basestate nuevoEstado) 
    {
        estadoActual = nuevoEstado;
        estadoActual.StateStart();
    }
}
