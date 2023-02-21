using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombateJugador : MonoBehaviour
{
    [SerializeField] private float vida;

    [SerializeField] private float maximoVida;

    [SerializeField] private BarraDeVida barraDeVida;

    // Start is called before the first frame update
    public void Start()
    {
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);

    }

    public void TomarDano(float dano)
    {
        vida -= dano;
        barraDeVida.CambiarVidaActual(vida);
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
