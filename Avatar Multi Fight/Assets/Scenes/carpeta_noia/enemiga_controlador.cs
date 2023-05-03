using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class enemiga_controlador : MonoBehaviour
{
    public int Id_Enemy;


    /* [SerializeField] private float velocidaddemovimiento;
      [SerializeField] private Transform[] puntordemovimiento; // puntos seria aixo
      [SerializeField] private float distancia;
      private int numrandom;
      private SpriteRenderer spriteRenderer;



      [SerializeField] private GameObject[] enemigos;
      [SerializeField] private float tiempoEnemigos;
      private float tiempoEnemigosSiguiente;
      //bool canJump;
      Animator anim1;


      //public int damage; //da�o barra de vida


      void Start()
      {
          anim1 = gameObject.GetComponent<Animator>();
          numrandom = Random.Range(0, puntordemovimiento.Length);
          //spriteRenderer = GetComponent<SpriteRenderer>();
          //Girar();
      }

     void Update()
     {
         transform.position = Vector2.MoveTowards(transform.position, puntordemovimiento[numrandom].position, velocidaddemovimiento * Time.deltaTime);
         if (Vector2.Distance(transform.position, puntordemovimiento[numrandom].position) < distancia)
         {

             numrandom = Random.Range(0, puntordemovimiento.Length);
            // Girar();

             //animacion pu�o




             tiempoEnemigosSiguiente += Time.deltaTime;
             if (tiempoEnemigosSiguiente >= tiempoEnemigos)
             {
                 tiempoEnemigosSiguiente = 0;
                 Crearenemigos();
             }
         }
     }


         void Crearenemigos()
          {
              numrandom = Random.Range(0, puntordemovimiento.Length);
              transform.position = Vector2.MoveTowards(transform.position, puntordemovimiento[numrandom].position, velocidaddemovimiento * Time.deltaTime);

              Instantiate(enemigos[numrandom], transform.position, Quaternion.identity);
          }

         /* void Girar()
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

       void OnCollisionEnter2D(Collision2D other)
      {

      }

      //CUANDO DETECTA A LA CHICA LE PEGA UN PU�ETAZO
       void OnCollisionStay2D(Collision2D collision)
      {
          if (collision.collider.CompareTag("Chica2"))
          {


          }
      }
  }

    ////////////////////////////////////////modificacio meva//////////////////////

 */




    /// <summary>
    /// ///////////////////////////////////
    /// </summary>







    /////////////////////////////////////////////////buena////////////////////////////////////////////////////////


    [SerializeField] private float velocidaddemovimiento;
    [SerializeField] private Transform[] puntordemovimiento; // puntos seria aixo
    [SerializeField] private float distancia;
    private int numrandom;
    private SpriteRenderer spriteRenderer;



    [SerializeField] private GameObject[] enemigos;
    [SerializeField] private float tiempoEnemigos;
    private float tiempoEnemigosSiguiente;
    //bool canJump;
    Animator anim1;


    //public int damage; //da�o barra de vida


    void Start()
    {
        Id_Enemy = 0;
        anim1 = gameObject.GetComponent<Animator>();
        numrandom = Random.Range(0, puntordemovimiento.Length);
        //spriteRenderer = GetComponent<SpriteRenderer>();
        //Girar();
    }

    private void Update()
    {
        tiempoEnemigosSiguiente += Time.deltaTime;
        if (tiempoEnemigosSiguiente >= tiempoEnemigos)
        {
            tiempoEnemigosSiguiente = 0;
            Crearenemigos();
        }
    }

    private void Crearenemigos()
    {
        Id_Enemy++; // ara porta 2 tios eliminats
        if (Id_Enemy <= 15)
        {




            int numeroEnemigo = Random.Range(0, enemigos.Length);
            Vector2 posicioAleatoria = new Vector2(Random.Range(-10, 10), Random.Range(0, 0));
            var newObject = Instantiate(enemigos[numeroEnemigo], posicioAleatoria, Quaternion.identity);
            newObject.name = "Player_1_" + Id_Enemy.ToString();


        }
        
    }

}
