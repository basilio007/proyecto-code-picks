using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class MenuPause : MonoBehaviour

{
    [SerializeField] private GameObject botonPause;

    [SerializeField] private GameObject menuPause;



    public void Pause()
    {
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Cerrar ()
    {
        
        UnityEditor.EditorApplication.isPlaying = false;
        //SceneManager.LoadScene(0);
        Application.Quit();
       // SceneManager.LoadScene(0);
        // SceneManager.LoadScene("Menu inicial-juego");
        // UnityEditor.EditorApplication.isPlaying = false;
       
    }
}