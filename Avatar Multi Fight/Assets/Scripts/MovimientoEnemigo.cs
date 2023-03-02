using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo: MonoBehaviour
{
    /* [SerializeField] public Transform jugador;
     [SerializeField] private float distancia;

     public Vector3 puntoInicial;
     private Animator animator;
     private SpriteRenderer spriteRenderer;


     private void Start()
     {
         animator = GetComponent<Animator>();
         puntoInicial = transform.position;
         spriteRenderer = GetComponent<SpriteRenderer>();

     }


     private void Update()
     {
         distancia = Vector2.Distance(transform.position, jugador.position);
         animator.SetFloat("distancia", distancia);
     }

     public void Girar(Vector3 objetivo)
     {
         if (transform.position.x < objetivo.x)
         {
             spriteRenderer.flipX = true;
         }
         else 
         {
             spriteRenderer.flipX = false;
         }
     }*/
    [SerializeField] private float velocidaddemovimiento;
    [SerializeField] private Transform[] puntordemovimiento;
    [SerializeField] private float distancia;
    private int numrandom;
    private SpriteRenderer spriteRenderer;

    //bool canJump;
    Animator anim1;

    void Start()
    {
        anim1 = gameObject.GetComponent<Animator>();
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

            //animacion pu�o

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
        if (other.collider.CompareTag("Chica2"))
        {
            anim1.SetTrigger("pu�o");
        }

    }



    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ASDF");


    }
}