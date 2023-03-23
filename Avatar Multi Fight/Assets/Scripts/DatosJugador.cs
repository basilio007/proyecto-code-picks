using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DatosJugador : MonoBehaviour
{
    public int vidaPlayer;
    public Slider vidaVisual;


    public event EventHandler MuerteJugadora;


   private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if(vidaPlayer <=0)
        {
            MuerteJugadora?.Invoke(this,EventArgs.Empty);
            Debug.Log("GAME OVER");
        }

    }

    public void restarVida(int vida)
    {
        Debug.Log("restarVda");
        vidaPlayer -= vida;
    }


}
