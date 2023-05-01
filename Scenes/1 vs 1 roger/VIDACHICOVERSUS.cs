using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VIDACHICOVERSUS : MonoBehaviour
{
    public static int vidaENEMIGO;
    public int vida_Vieja;
    public Slider vidaVisual;
    Animator Anim2;
    public GameObject END;


    public event EventHandler MuerteJugador;

    void Start()
    {
        Anim2 = gameObject.GetComponent<Animator>();
        vidaENEMIGO = 100;
        vida_Vieja = 100;
    }


    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vidaENEMIGO;

        if (vidaENEMIGO != vida_Vieja)
        {
            Anim2.SetTrigger("daño");
            Debug.Log(vida_Vieja);

            vida_Vieja = vidaENEMIGO;
        }


        if (vidaENEMIGO <= 0)
        {
            //MuerteJugador?.Invoke(this, EventArgs.Empty);
            END.SetActive(true);

            Debug.Log("GAME OVER");
        }

    }
}
