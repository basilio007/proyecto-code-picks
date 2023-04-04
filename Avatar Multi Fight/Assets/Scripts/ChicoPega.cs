using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicoPega : MonoBehaviour
{
    public int damage;
    public GameObject Chica2;

    public float time_to_hit;
    public float timeCooldown;
    Animator Anim1;

    void Start() 
    {
        Anim1 = gameObject.GetComponent<Animator>();
        timeCooldown = 1f;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log(col.tag);

        if (col.tag == "Chica2")
        {
            if (Time.timeSinceLevelLoad > time_to_hit)
            {
                time_to_hit = Time.timeSinceLevelLoad + timeCooldown;
                DatosJugador.vidaPlayer -= damage;
                Anim1.SetBool("Puño", true);
            }
            else 
            {
                Anim1.SetBool("Puño",false);
            }
            
            //Chica2.GetComponent<DatosJugador>().restarVida(damage);
            Debug.Log("entra puño de tio duro");

        }

        if (col.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }

    


}
