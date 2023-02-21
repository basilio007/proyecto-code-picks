using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    // public Image barraDeVida;

    //public float vidaActual;

    //public float vidaMaxima;
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMaxima(float vidaMaxima)
    {
        slider.maxValue = vidaMaxima;
    }
    public void CambiarVidaActual(float cantidadVida)
    {
        slider.maxValue = cantidadVida;
    }
    public void InicializarBarraDeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaActual(cantidadVida);
    }



    // void Update()
    //{
    //  barraDeVida.fillAmount = vidaActual / vidaMaxima;
    //}
}
