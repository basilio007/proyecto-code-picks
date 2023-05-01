using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class VIDACHICO : MonoBehaviour
{
    public int vidaENEMIGO;
    public int vida_Vieja;
    //public Slider vidaVisual;
    Animator Anim2;

   // public GameObject END;


    public event EventHandler MuerteChico;

    void Start()
    {
        Anim2 = gameObject.GetComponent<Animator>();
        vidaENEMIGO = 100;
        vida_Vieja = 100;
    }


    private void Update()
    {


        if (vidaENEMIGO != vida_Vieja)
        {
            
            Debug.Log(vida_Vieja);

            vida_Vieja = vidaENEMIGO;
        }


        if (vidaENEMIGO <= 0)
        {
            
            MuerteChico?.Invoke(this, EventArgs.Empty);
            //Anim2.SetTrigger("DA�O_CHICO");
            Destroy(gameObject);
           

            Debug.Log("ENEMIGO DERROTADO");
        }

    }

}
