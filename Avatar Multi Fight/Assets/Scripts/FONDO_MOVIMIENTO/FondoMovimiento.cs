using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    [SerializeField] private Vector2 velocidadMovimiento;
    private Vector2 offset;

    private Material material;

    private Rigidbody2D chicaCamara;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        chicaCamara = GameObject.FindGameObjectWithTag("Chica2").GetComponent<Rigidbody2D>();//la camara seguira a lachica

    }
    private void Update()
    {
        //offset = velocidadMovimiento * Time.deltaTime;
        offset = (chicaCamara.velocity.x * 0.3f) * velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
