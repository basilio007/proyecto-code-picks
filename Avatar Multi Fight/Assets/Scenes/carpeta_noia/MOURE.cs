using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOURE : MonoBehaviour
{
    [SerializeField] public float velocidaddemovimiento;
    [SerializeField] public Transform puntordemovimiento;
    [SerializeField] public float distancia;
    public int numrandom;
    public SpriteRenderer spriteRenderer;

    //bool canJump;
    Animator anim1;


    //public int damage; //da�o barra de vida


    void Start()
    {
        puntordemovimiento = GameObject.Find("Chica2").transform;
        anim1 = gameObject.GetComponent<Animator>();
        numrandom = Random.Range(0, 1);
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntordemovimiento.position, velocidaddemovimiento * Time.deltaTime);
        gameObject.GetComponent<Animator>().SetBool("moving", true);
        if (Vector2.Distance(transform.position, puntordemovimiento.position) < distancia)
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            numrandom = Random.Range(0, 1);
            Girar();

            //animacion pu�o

        }


    }
    private void Girar()
    {
        if (transform.position.x < puntordemovimiento.position.x)
        {
           
            spriteRenderer.flipX = true;

        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
            spriteRenderer.flipX = false;
        }
    }

    private float tiempo;

    private void OnCollisionEnter2D(Collision2D other)
    {
        /*
        if (other.collider.CompareTag("Chica2"))
        {
           
            anim1.SetTrigger("pu�o");
           
        }
        else if (!other.collider.CompareTag("Chica2"))
        {
            anim1.SetBool("movimiento", true);
        }*/

    }

    //CUANDO DETECTA A LA CHICA LE PEGA UN PU�ETAZO
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Chica2"))
        {


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


    }
}
