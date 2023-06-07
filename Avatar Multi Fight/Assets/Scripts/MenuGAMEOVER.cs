using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class MenuGAMEOVER : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;
    private DatosJugador datosjugador;

    private void Start()
    {
        //quan la vida de la nostra noia estigui a 0 saltara el GAME OVER
        datosjugador = GameObject.FindGameObjectWithTag("Chica2").GetComponent<DatosJugador>();
        datosjugador.MuerteJugadora += ActivarMenu;


    }

    private void ActivarMenu(object sender, EventArgs e)
    {
    menuGameOver.SetActive (true);
    }
    





    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        Application.Quit();
    }
   
}
