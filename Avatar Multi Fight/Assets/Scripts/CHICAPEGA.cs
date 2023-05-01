using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHICAPEGA : MonoBehaviour
{
    public int damage_chica;
    public GameObject Enemigo;

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

                //Anim3.SetTrigger("PU�O");
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

        if (col.tag == "Enemigo")

        {
            if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A))
            {
                if (Time.timeSinceLevelLoad > time_to_hit)
                {
                    time_to_hit = Time.timeSinceLevelLoad + timeCooldown;
                    
                    GameObject.Find(col.name).GetComponent<VIDACHICO>().vidaENEMIGO -= damage_chica;

                    //Anim3.SetTrigger("PU�O");
                }
                else
                {
                }

                //Chica2.GetComponent<DatosJugador>().restarVida(damage);
                

            }

            if (col.tag == "Enemigo")
            {
                
            }
        }
    }


}
