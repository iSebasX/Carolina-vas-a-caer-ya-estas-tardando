using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI muchoTexto;

    private void Start()
    {
        muchoTexto = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        muchoTexto.text = puntos.ToString("0");
    }
    public void Sumarpuntos (float nuevospuntos) 
    {
        puntos += nuevospuntos;
    }
}
