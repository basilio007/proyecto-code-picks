using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DatosJugador : MonoBehaviour
{
    public static int vidaPlayer;
    public int vida_Vieja;
    public Slider vidaVisual;
    Animator Anim2;
    public GameObject END;

    ChicaController chica = null;


    public event EventHandler MuerteJugadora;

    void Start() 
    {
        GameObject obj = GameObject.FindGameObjectWithTag("VidaVisual");

        Anim2 = gameObject.GetComponent<Animator>();
        vidaVisual = obj.GetComponent<Slider>();

        chica = obj.GetComponent<ChicaController>();
        vidaPlayer = chica.vidaPlayer;
        vida_Vieja = 100;
    }


   private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaPlayer;

        if (vidaPlayer != vida_Vieja)
        {
           // Anim2.SetTrigger("dano");
            vida_Vieja = vidaPlayer;
            chica.vidaPlayer = vida_Vieja;
        }


        if(vidaPlayer <=0)
        {
            MuerteJugadora?.Invoke(this,EventArgs.Empty);
            END.SetActive(true);

            Debug.Log("GAME OVER");
        }

    }


}
