using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicoPega : MonoBehaviour
{
    public int damage;
    public GameObject Chica2;

    public float time_to_hit;
    public float timeCooldown;

    public float time_Visual;
    Animator Anim1;

    void Start() 
    {
        // diem que te que trobar a la tia per aque faci mal
        Chica2 = GameObject.FindGameObjectWithTag("Chica2");
        Anim1 = gameObject.GetComponent<Animator>();
        timeCooldown = 1f;
    }
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {
        //un cop xoqui amb la tia la començara a pegar
        if (col.tag == "Chica2")
        {
            if (Time.timeSinceLevelLoad > time_to_hit)
            {
                // li baixara la vida i es podra veure al SLIDER que hem fet de barra de vida CHICA
                //quan pego entre cooldown de la barra de vida i l'ostia del enemic i fem aixo per a que a l'hora de pegar el enemic just quan pegui et baixi la teva barra de vida al mateix instant
                time_to_hit = Time.timeSinceLevelLoad + timeCooldown;
                DatosJugador.vidaPlayer -= damage;
                Anim1.SetBool("Puno", true);
            }

            //Chica2.GetComponent<DatosJugador>().restarVida(damage);


        }

        if (col.tag == "Enemigo")
        {

        }
    }


    


}
