using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Cura : MonoBehaviour
{
    [SerializeField] float Heal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ControladorVida>())
        {
            collision.gameObject.GetComponent<ControladorVida>().RecibirCura(Heal);
            Destroy(gameObject);
        }
    }
}