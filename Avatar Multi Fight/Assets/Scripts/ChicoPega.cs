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
        Chica2 = GameObject.FindGameObjectWithTag("Chica2");
        Anim1 = gameObject.GetComponent<Animator>();
        timeCooldown = 1f;
    }
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D col)
    {

        if (col.tag == "Chica2")
        {
            if (Time.timeSinceLevelLoad > time_to_hit)
            {
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
