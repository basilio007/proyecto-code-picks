using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicoPega : MonoBehaviour
{
    public int damage;
    public GameObject Chica2;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Chica2")
        {

            Chica2.GetComponent<DatosJugador>().restarVida(damage);
            Debug.Log("entra puño de tio duro");

        }

        if (other.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }

    


}
