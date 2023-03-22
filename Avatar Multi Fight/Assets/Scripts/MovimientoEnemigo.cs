using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo: MonoBehaviour
{
 
    [SerializeField] private float velocidaddemovimiento;
    [SerializeField] private Transform[] puntordemovimiento;
    [SerializeField] private float distancia;
    private int numrandom;
    private SpriteRenderer spriteRenderer;

    //bool canJump;
    Animator anim1;


    //public int damage; //daño barra de vida
    

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

            //animacion puño

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
        /*
        if (other.collider.CompareTag("Chica2"))
        {
           
            anim1.SetTrigger("puño");
           
        }
        else if (!other.collider.CompareTag("Chica2"))
        {
            anim1.SetBool("movimiento", true);
        }*/

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Chica2"))
        {

            anim1.SetTrigger("puño");

        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Chica2")
        {
            
            anim1.GetComponent<barradevida>().vidaactual -= damage;
        }
        
    }
    */













    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ASDF");


    }
}