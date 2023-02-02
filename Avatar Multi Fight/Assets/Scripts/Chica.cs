using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chica : MonoBehaviour
{
    public float speed; //variable velocidad de traslado de un punto a otro
    public Rigidbody2D salto;//variable rigidbody del salto
    public float fuerza; //variable control de fuerza en el  salto

    //variables de control del personajecon el suelo
    public Transform checker;
    public float radiofloor;
    public bool touchfloor;
    public LayerMask isfloor;

    // Update is called once per frame
    void Update()
    {
        EjecutarMovement();
        if (Input.GetKey(KeyCode.Space))
        {
            salto.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
        }
        touchfloor = Physics2D.OverlapCircle(checker.position,radiofloor,isfloor);   


    }


   void EjecutarMovement()
    {
        float inputMovement = Input.GetAxis("Horizontal");
        Rigidbody2D Rigidbody = GetComponent<Rigidbody2D>();

        Rigidbody.velocity = new Vector2(inputMovement * speed, Rigidbody.velocity.y);

        

    }
}
