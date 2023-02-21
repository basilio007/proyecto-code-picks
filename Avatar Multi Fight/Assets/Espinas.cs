 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinas : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDaño;
    private float tiempoSiguienteDano;
    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            tiempoSiguienteDano -= Time.deltaTime;
            if(tiempoSiguienteDano < 0)
            {
                other.GetComponent<CombateJugador>().TomarDano(5);
                tiempoSiguienteDano = tiempoEntreDaño;
            }
        }
    }
}
