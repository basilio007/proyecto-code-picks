using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicamovimiento : MonoBehaviour
{
    [SerializeField] private float velocidaddemovimiento;
    [SerializeField] private Transform[] puntordemovimiento;
    [SerializeField] private float distancia;
    private int numrandom;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        numrandom = Random.Range(0, puntordemovimiento.Length);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

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

    private float tiempo;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("Jugador Entro");
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            tiempo += Time.deltaTime;
            Debug.Log("Jugador en bloque");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            Debug.Log("Jugador Salio : " + tiempo);
            tiempo = 0;
        }
    }


}
   



