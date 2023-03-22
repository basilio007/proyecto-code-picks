using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eaglemovement : MonoBehaviour
{
    [SerializeField] private float velocidaddemovimiento;
    [SerializeField] private Transform[] puntordemovimiento;
    [SerializeField] private float distancia;
     private int numrandom;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        numrandom = Random.Range(0, puntordemovimiento.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntordemovimiento[numrandom].position, velocidaddemovimiento * Time.deltaTime);
        if (Vector2.Distance(transform.position, puntordemovimiento[numrandom].position) < distancia)
        {

            numrandom = Random.Range(0, puntordemovimiento.Length);
            Girar();
        }


    }
    private void Girar()
    {
        if (transform.position.x < puntordemovimiento[numrandom].position.x) 
        {
            spriteRenderer.flipX = true;

        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }
}
