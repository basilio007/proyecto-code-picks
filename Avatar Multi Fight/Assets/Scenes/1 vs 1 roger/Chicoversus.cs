using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicoversus : MonoBehaviour
{

    //public float VidaActual;




    //bool canJump;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    //frame por segundo varia depende de lo rapido que el ordenador . para evitar esto utilizamos 
    void Update()
    {

        //comprobar por cada frame si estamos utilizando una tecla o no

        //sera true si la flecha left esta pulsada
        if (Input.GetKey(KeyCode.A))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-300f * Time.deltaTime, 0));
            //gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }

        if (Input.GetKey(KeyCode.D))
        {

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(300f * Time.deltaTime, 0));
            //gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        /*if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            anim.SetBool("moving", false);
        }
        */
       

        //animacion puño tio
        if (Input.GetKeyDown(KeyCode.Z))
        {
            anim.SetBool("Puño",true);
        }
      


        //solo se activa si la tecla esta pulsada
        /*if (Input.GetKeyDown("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100f));

        }*/
    }

    //colider con el que se ha chocado
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.transform.tag == "ground")
        {
            canJump = true;
        }*/
    }

    //CUANDO DETECTA EL TIO ENEMIGO HACE LA ANIMACION  QUE ESTA HERIDA
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Chica2"))
        {

            //anim.SetTrigger("daño");


        }
        else if (!collision.collider.CompareTag("Chica2"))
        {

            anim.SetBool("moving", true);
        }
    }

}
