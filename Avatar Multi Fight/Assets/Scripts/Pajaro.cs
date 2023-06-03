using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{

    //Creamos un holder de la caca, un alternador para el temporizador y un lugar donde almazenar el clon

    public GameObject caca;

    public bool timer;
    public GameObject clone;

    
    void Start()
    {
        //Buscamos la caca y seteamos el temporizador
        timer = true;
        caca = GameObject.Find("Cagada");
    }

    
    void Update()
    {
        //empezamos el alternador
        if (timer)
        {
            Invoke("Inst",10);
            timer = false;
        }
        
    }

    void Inst() 
    {
        //Despues de invocase crea un clon de la caca i lo setea a la posicion del pajaro, cae y si no toca nada se auto destruye
        clone = Instantiate(caca, gameObject.transform.position, gameObject.transform.rotation);
        Debug.Log("CACA");
        timer = true;

        Destroy(clone, 5f);
    }
}
