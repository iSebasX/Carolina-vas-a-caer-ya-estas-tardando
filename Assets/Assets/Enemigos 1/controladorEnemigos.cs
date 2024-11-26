using UnityEngine;
using System.Collections.Generic;

public class ControladorEnemigos : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rigid;

    public Collider2D[] objetivos;
    public Collider2D objetivo;
    public float velocidad;
    public Transform centroVision;
    public Vector2 tamañoVision;
    public LayerMask capaVision;

    public float distancia;

    public List<Daño> Luisa;
    public RaycastHit2D rayo;
    MovimientoStates movimientoStates;

    public bool movimiento;

    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

        InvokeRepeating("DetectarEnemigos", 0, 0.3f);
    }

    void Update()
    { 
        Flip();
    }

    public void DetectarEnemigos()
    {
        objetivos = Physics2D.OverlapBoxAll(centroVision.position, tamañoVision, 0, capaVision);
        anim.SetBool("jugadorDetectado", objetivo != null);
        if (objetivos.Length > 0)
        {
            float distancia2 = Mathf.Infinity;
            int indice = -1;

            for (int U = 0; U < objetivos.Length; U++)
            {
                if (Vector2.Distance(transform.position, objetivos[U].transform.position) < distancia2)
                {
                    distancia2 = Vector2.Distance(transform.position, objetivos[U].transform.position);
                    indice = U;
                }
            }
            objetivo = objetivos[indice];
        }
        else
        {
            objetivo = null;
        }

        if (objetivo != null)
        {
            distancia = Vector2.Distance(transform.position, objetivo.transform.position);
            anim.SetFloat("Distancia", distancia);
        }
    }

    public void DesactivarMovimiento()
    {
        movimiento = false;
    }

    public void ActivarMovimiento()
    {
        movimiento = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(centroVision.position, tamañoVision);

        Gizmos.color = Color.yellow;
        Vector2 direccionRaycast = Vector2.left;
        float distanciaRaycast = Mathf.Infinity;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3)direccionRaycast * distanciaRaycast);
    }

    private void ActivarDaño()
    {
        foreach (var item in Luisa)
        {
            item.EnableCollitions();
        }
    }

    private void DesactivarDaño()
    {
        foreach (var item in Luisa)
        {
            item.DisableCollitions();
        }
    }

    private void Flip()
    {
        if (objetivo != null)
        {
            Vector3 direccion = objetivo.transform.position - transform.position;

            if (direccion.x > 0)
            {
                transform.localEulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
            }
            else if (direccion.x < 0)
            {
                transform.localEulerAngles = new Vector3(0, 180, transform.eulerAngles.z);
            }
        }
    }
}
