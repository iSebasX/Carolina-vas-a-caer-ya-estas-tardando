using UnityEngine;
using System.Collections.Generic;

public class controladorEnemigos : MonoBehaviour
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

    public bool movimiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();

        InvokeRepeating("DetectarEnemigos",0,0.3f);
    }

    public void DetectarEnemigos()
    {
        objetivos = Physics2D.OverlapBoxAll(centroVision.position, tamañoVision, 0, capaVision);
        anim.SetBool("jugadorDetectado", objetivo);
        if (objetivos.Length > 0)
        {
            float distancia2 = Mathf.Infinity;
            int indice = -1;

            for (int U = 0; U < objetivos.Length; U++) 
            {
               if (Vector2.Distance(transform.position, objetivos[U].transform.position) < distancia2)
                {
                    distancia = Vector2.Distance(transform.position, objetivos[U].transform.position);
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

    public void DesactivarMovimiento () 
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
    }

    private void ActivarDaño () 
    {
        foreach (var item in Luisa) 
        {
           item.EnableCollitions();
        }
    }

    private void DesactivarDaño () 
    {
        foreach (var item in Luisa)
        {
            item.DisableCollitions();
        }
    }
}
