using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChicoPega : MonoBehaviour
{
    public int damage;
    public GameObject Chica2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chica2")
        {

            Chica2.GetComponent<DatosJugador>().vidaPlayer -= damage;
            Debug.Log("entra puño");

        }

        if(other.tag == "Enemigo")
        {
            Debug.Log("Esto es un enemigo");
        }
    }



}
