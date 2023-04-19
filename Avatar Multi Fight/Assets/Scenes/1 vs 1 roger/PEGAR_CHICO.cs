using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PEGAR_CHICO : MonoBehaviour
{
    public int damage_enemigo;
    public GameObject Chica2;

    public float time_to_hit;
    public float timeCooldown;
    Animator Anim3;

    void Start()
    {
        Anim3 = gameObject.GetComponent<Animator>();
        timeCooldown = 1.67f;

    }
    /*void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A))
        {

            if (Time.timeSinceLevelLoad > time_to_hit)
            {
                time_to_hit = Time.timeSinceLevelLoad + timeCooldown;
                VIDACHICO.vidaENEMIGO -= damage_chica;

                //Anim3.SetTrigger("PUÑO");
            }
            else
            {
            }

            //Chica2.GetComponent<DatosJugador>().restarVida(damage);
            Debug.Log("OSTIA CHICA");
        }
    }
    */





    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(col.tag);

        if (col.tag == "Chica2")

        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (Time.timeSinceLevelLoad > time_to_hit)
                {
                    time_to_hit = Time.timeSinceLevelLoad + timeCooldown;
                    DatosJugador.vidaPlayer -= damage_enemigo;

                    //Anim3.SetTrigger("PUÑO");
                }
                else
                {
                }

                //Chica2.GetComponent<DatosJugador>().restarVida(damage);
                Debug.Log("OSTIA TIO DURO");

            }

            if (col.tag == "Chica2")
            {
                Debug.Log("Esto es la chica");
            }
        }
    }

}
