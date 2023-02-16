using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaglemovement : MonoBehaviour
{
    [SerilizeField] private float velocidaddemovimiento;
    [SerilizeField] private Transform puntordemovimiento;
    [SerilizeField] private distancia;
     private int numrandom;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        numrandom = Random.Range(0, puntordemovimiento.length);
        spriteRenderer = GetComponent<spriteRenderer>();

    }


    // Update is called once per frame
    void Update()
    {
        Transform.position = Vector2.MoveTowards(Transform.position, puntordemovimiento[numrandom].position, velocidaddemovimiento * Time.deltatime);
        if (Vector2.Distance(trnasform.pposition, puntordemovimiento[numrandom].position) < distancia
            numrandom = )
        {

        }


    }
}
