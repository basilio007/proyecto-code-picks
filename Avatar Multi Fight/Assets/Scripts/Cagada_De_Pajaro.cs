using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cagada_De_Pajaro : MonoBehaviour
{

    //Creamos un valor para guardar el random.range y un alternador para el temporizador


    public int vAlue;
    public bool tt;


    void Start()
    {
        //Seteamos el temporizador para empezar
        tt = true;
    }

    
    void Update()
    {
        //Si el temporizador es true da un valor entre 0 y 1
        if (tt)
        {
            Invoke("Tiempo_1", 5);
            vAlue = Random.Range(0, 2);
            tt = false;
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // En el caso de que la caca colisione con la chica decidirimes si hacerle daño o suvirle la vida segun el valor de vAlue
        if(col.gameObject.tag == "Chica2") 
        {
            if (vAlue == 1) 
            {
                DatosJugador.vidaPlayer = DatosJugador.vidaPlayer - 10;
                Destroy(gameObject);            
            }
            else
            {
                DatosJugador.vidaPlayer = DatosJugador.vidaPlayer + 5;
                Destroy(gameObject);
            }
        }
    }

    void Tiempo_1() 
    {
        //El resto del temporizador
        tt = true;
    }
}
