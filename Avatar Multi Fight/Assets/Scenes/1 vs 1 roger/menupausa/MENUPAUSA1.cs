using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MENUPAUSA1 : MonoBehaviour
{
    [SerializeField] private GameObject botonPause;

    [SerializeField] private GameObject menuPause;

    private bool JuegoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (JuegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Pause()
    {
        JuegoPausado = true;
        Time.timeScale = 0f;
        botonPause.SetActive(false);
        menuPause.SetActive(true);
    }

    public void Reanudar()
    {
        JuegoPausado = false;
        Time.timeScale = 1f;
        botonPause.SetActive(true);
        menuPause.SetActive(false);
    }

    public void Reiniciar()
    {
        JuegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Cerrar()
    {

        Application.Quit();
        //SceneManager.LoadScene(0);
        // menuPause.SetActive(true);
        // SceneManager.LoadScene(0);
        // SceneManager.LoadScene("Menu inicial-juego");
        // UnityEditor.EditorApplication.isPlaying = false;

    }
}
